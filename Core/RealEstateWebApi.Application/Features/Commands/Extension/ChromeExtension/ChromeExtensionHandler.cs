﻿using MediatR;
using Microsoft.AspNetCore.Http;
using RealEstateWebApi.Application.Abstractions.Scraping;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using System.Globalization;
using System.Security.Claims;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace RealEstateWebApi.Application.Features.Commands.Extension.ChromeExtension
{
    public class ChromeExtensionHandler : IRequestHandler<ChromeExtensionRequest, ChromeExtensionResponse>
    {
        private readonly IShScrapingService _shScrapingService;
        private readonly ICustomerOwnedPropertyWriteRepository _customerOwnedPropertyWriteRepository;
        private readonly ICustomerOwnedPropertyReadRepository _customerOwnedPropertyReadRepository;
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;
        private readonly IPropertyListingPhotoWriteRepository _propertyListingPhotoWriteRepository;
        private readonly ICityReadRepository _cityReadRepository;
        private readonly IDistrictReadRepository _districtReadRepository;
        private readonly INeighborhoodReadRepository _neighborhoodReadRepository;
        private readonly IPropertyTypeReadRepository _propertyTypeReadRepository;
        private readonly IPropertyTypeWriteRepository _propertyTypeWriteRepository;
        private readonly IPropertyStatusReadRepository _propertyStatusReadRepository;
        private readonly IPropertyStatusWriteRepository _propertyStatusWriteRepository;
        private readonly IPropertyCategoryReadRepository _propertyCategoryReadRepository;
        private readonly IPropertyCategoryWriteRepository _propertyCategoryWriteRepository;
        private readonly IOuterPropertyListingReadRepository _outerPropertyListingReadRepository;
        private readonly IOuterPropertyListingWriteRepository _outerPropertyListingWriteRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ChromeExtensionHandler(IShScrapingService shScrapingService,
        ICustomerOwnedPropertyWriteRepository customerOwnedPropertyWriteRepository,
        ICustomerReadRepository customerReadRepository,
        IPropertyListingPhotoWriteRepository propertyListingPhotoWriteRepository,
        ICustomerWriteRepository customerWriteRepository,
        ICityReadRepository cityReadRepository,
        IDistrictReadRepository districtReadRepository,
        ICustomerOwnedPropertyReadRepository customerOwnedPropertyReadRepository,
        IHttpContextAccessor httpContextAccessor,
        INeighborhoodReadRepository neighborhoodReadRepository,
        IPropertyTypeReadRepository propertyTypeReadRepository,
        IPropertyStatusReadRepository propertyStatusReadRepository,
        IPropertyStatusWriteRepository propertyStatusWriteRepository,
        IPropertyTypeWriteRepository propertyTypeWriteRepository,
        IOuterPropertyListingReadRepository outerPropertyListingReadRepository,
        IOuterPropertyListingWriteRepository outerPropertyListingWriteRepository,
        IPropertyCategoryReadRepository propertyCategoryReadRepository,
        IPropertyCategoryWriteRepository propertyCategoryWriteRepository)
        {
            _shScrapingService = shScrapingService;
            _customerOwnedPropertyWriteRepository = customerOwnedPropertyWriteRepository;
            _customerReadRepository = customerReadRepository;
            _propertyListingPhotoWriteRepository = propertyListingPhotoWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _cityReadRepository = cityReadRepository;
            _districtReadRepository = districtReadRepository;
            _customerOwnedPropertyReadRepository = customerOwnedPropertyReadRepository;
            _httpContextAccessor = httpContextAccessor;
            _neighborhoodReadRepository = neighborhoodReadRepository;
            _propertyTypeReadRepository = propertyTypeReadRepository;
            _propertyStatusReadRepository = propertyStatusReadRepository;
            _propertyStatusWriteRepository = propertyStatusWriteRepository;
            _propertyTypeWriteRepository = propertyTypeWriteRepository;
            _outerPropertyListingReadRepository = outerPropertyListingReadRepository;
            _outerPropertyListingWriteRepository = outerPropertyListingWriteRepository;
            _propertyCategoryReadRepository = propertyCategoryReadRepository;
            _propertyCategoryWriteRepository = propertyCategoryWriteRepository;
        }
        public async Task<ChromeExtensionResponse> Handle(ChromeExtensionRequest request, CancellationToken cancellationToken)
        {
            if(!request.Url.Contains("sahibinden"))
            {
                return new ChromeExtensionResponse()
                {
                    Message = "Şimdilik Sh dışında bir link gönderemezsiniz.",
                    Success = false
                };
            }

            OuterPropertyListing propertyListingDetail = await _shScrapingService.GetListingDetail(request.Url, request.OuterHTML, Path.Combine("ShScraping"));
        

            // shscrapingden dönen datayı kontrol ve kayıt
            OuterPropertyListing pldResult = await _outerPropertyListingReadRepository.GetSingleAsync(x => x.Id == propertyListingDetail.Id);
            if (pldResult is null)
            {
                pldResult = await _outerPropertyListingWriteRepository.AddAndSaveAsync(propertyListingDetail);

            }

            if (pldResult.PhotoPaths?.Count() > 0)
            {
                await _propertyListingPhotoWriteRepository.AddRangeAsync(propertyListingDetail.PropertyListingPhotos.AsEnumerable());
                await _propertyListingPhotoWriteRepository.SaveAsync();
            }

            // il,ilçe ve mahalleyi mevcut databaseden alma
            propertyListingDetail.Neighborhood = propertyListingDetail.Neighborhood.Trim().ToUpper(CultureInfo.CreateSpecificCulture("tr-TR"));
            var city = await _cityReadRepository.GetSingleAsync(x => x.Name.Trim() == propertyListingDetail.City.Trim().ToUpper(CultureInfo.CreateSpecificCulture("tr-TR")));
            var district = await _districtReadRepository.GetSingleAsync(x => x.CityKey == city.Key && x.Name.Trim() == propertyListingDetail.District.Trim().ToUpper(CultureInfo.CreateSpecificCulture("tr-TR")));
            var neighborhood = await _neighborhoodReadRepository.GetSingleAsync(x => x.DistrictKey == district.Key && x.Name.Trim() == propertyListingDetail.Neighborhood);

            // customer kontrolü yoksa kayıt 
            Domain.Entities.Customer customer;
            if (request.CustomerId != null || request.CustomerId > 0)
            {
                customer = await _customerReadRepository.GetByIdAsync((uint)request.CustomerId);
                if (customer is null)
                    return new ChromeExtensionResponse()
                    {
                        Message = "Müşteri datası bulunamadı",
                        Success = false
                    };
            }
            else
            {
                string[] fullname = propertyListingDetail.ListingUserName.Split(" ");
                var numbers = propertyListingDetail.ListingPhoneNumbers.Split(" ").Where(x => x.StartsWith("05")).ToArray();

                customer = await _customerReadRepository.GetSingleAsync(x => x.MobileNumber == numbers[0].Remove(0, 1) || x.MobileNumber2 == numbers[0].Remove(0, 1));

                if (customer == null && numbers.Length > 1)
                    customer = await _customerReadRepository.GetSingleAsync(x => x.MobileNumber == numbers[1].Remove(0, 1) || x.MobileNumber2 == numbers[1].Remove(0, 1));

                if (customer == null)
                {
                    uint loginUserId = uint.Parse(_httpContextAccessor.HttpContext?.User?.Claims?.FirstOrDefault(e => ClaimTypes.NameIdentifier == e.Type)?.Value ?? "0");
                    customer = await _customerWriteRepository.AddAndSaveAsync(new Domain.Entities.Customer()
                    {
                        FirstName = fullname[0] + (fullname.Length > 2 ? " " + fullname[1] : ""),
                        LastName = fullname.Length > 2 ? String.Join(" ", fullname.Skip(2).ToArray()) : fullname[1],
                        FullName = String.Join(" ", fullname),
                        MobileNumber = numbers.First().Remove(0, 1),
                        MobileNumber2 = numbers.Skip(1).FirstOrDefault()?.Remove(0, 1),
                        CityId = city.Id,
                        DistrictId = district.Id,
                        RegisterUserId = loginUserId,
                        AssignedUserId = loginUserId
                    });
                    if (customer == null)
                        return new ChromeExtensionResponse()
                        {
                            Message = "Db ye kayıt edilirken bir hata alındı.",
                            Success = false
                        };
                }
            }

            // herhangi bir sahip olunan mülk de kayıtlımı kontrolü
            
            var cospResult = await _customerOwnedPropertyReadRepository.GetSingleAsync(x => x.OuterPropertyListingId == pldResult.Id);
            if (cospResult is not null)
            {
                string descriptionStart = $"{customer.Id} id müşterinin ilanı ile aynı, ";
                string firstControlMessage = string.Empty;
                if (customer.Id == cospResult.CustomerId && pldResult.ListingDate != propertyListingDetail.ListingDate)
                {
                    descriptionStart = $"{DateTime.Now.Date} itibariyle tarih {pldResult.ListingDate.Value.Date.ToString("dd/MM/yyyy")} -> {propertyListingDetail.ListingDate.Value.Date.ToString("dd/MM/yyyy")} olarak güncellenmiştir. \n\n";
                    cospResult.Description = descriptionStart + cospResult.Description;
                    await _customerOwnedPropertyWriteRepository.SaveAsync();
                    firstControlMessage += $" tarih güncellemesi yapıldı.";
                }

                if (customer.Id == cospResult.CustomerId && pldResult.Price != propertyListingDetail.Price)
                {
                    descriptionStart = $"{DateTime.Now.Date} itibariyle fiyat {pldResult.Price} -> {propertyListingDetail.Price} olarak güncellenmiştir. \n\n";
                    cospResult.Price = propertyListingDetail.Price;
                    cospResult.Description = descriptionStart + cospResult.Description;
                    await _customerOwnedPropertyWriteRepository.SaveAsync();
                    firstControlMessage += $" fiyat güncellemesi yapıldı.";
                    return new ChromeExtensionResponse()
                    {
                        Message = firstControlMessage,
                        Success = true,
                    };
                }
                else
                {
                    return new ChromeExtensionResponse()
                    {
                        Message = "Aynı ilan birden çok kullanıcıya kayıt edilemez",
                        Success = false
                    };
                }
            }



            // property category, property type ve status database den alma yoksa ekleme
            var propertyCategory = await _propertyCategoryReadRepository.GetSingleAsync(x => x.Title.Trim() == propertyListingDetail.PropertyCategory.Trim());
            if (propertyCategory == null)
                propertyCategory = await _propertyCategoryWriteRepository.AddAndSaveAsync(new Domain.Entities.PropertyCategory() { Title = propertyListingDetail.PropertyCategory.Trim() });

            var propertyStatus = await _propertyStatusReadRepository.GetSingleAsync(x => x.PropertyCategoryId == propertyCategory.Id && x.Title.Trim() == propertyListingDetail.PropertyStatus.Trim());
            if (propertyStatus == null)
                propertyStatus = await _propertyStatusWriteRepository.AddAndSaveAsync(new Domain.Entities.PropertyStatus() { PropertyCategoryId = propertyCategory.Id, Title = propertyListingDetail.PropertyStatus.Trim() });


            var propertyType = await _propertyTypeReadRepository.GetSingleAsync(x => x.PropertyStatusId == propertyStatus.Id && x.Title.Trim() == propertyListingDetail.PropertyType.Trim());
            if (propertyType == null)
                propertyType = await _propertyTypeWriteRepository.AddAndSaveAsync(new Domain.Entities.PropertyType() { PropertyStatusId = propertyStatus.Id, Title = propertyListingDetail.PropertyType.Trim() });



            cospResult = await _customerOwnedPropertyWriteRepository.AddAndSaveAsync(new Domain.Entities.CustomerOwnedProperty()
            {
                CustomerId = customer.Id,
                OuterPropertyListingId = pldResult.Id,
                LivingRoomCount = (ushort)pldResult.LivingRoomCount,
                RoomCount = pldResult.RoomCount,
                CityId = city.Id,
                DistrictId = district.Id,
                NeighborhoodId = neighborhood.Id,
                PropertyCategoryId = propertyCategory.Id,
                PropertyTypeId = propertyType.Id,
                PropertyStatusId = propertyStatus.Id,
                ShLink = request.Url,
                Price = pldResult.Price,
                //Description = pldResult.Description
            });

            if (cospResult is null)
                return new ChromeExtensionResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };


            return new ChromeExtensionResponse()
            {
                Message = "Kayıt başarılı!",
                Success = true
            };
        }
    }
}
