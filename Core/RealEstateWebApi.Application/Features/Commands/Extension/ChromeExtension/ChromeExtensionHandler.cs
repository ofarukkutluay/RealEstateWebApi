using MediatR;
using Microsoft.AspNetCore.Http;
using RealEstateWebApi.Application.Abstractions.Scraping;
using RealEstateWebApi.Application.Abstractions.Storage;
using RealEstateWebApi.Application.Features.Commands.Customer.CreateCustomer;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using System.Globalization;
using System.Security.Claims;

namespace RealEstateWebApi.Application.Features.Commands.Extension.ChromeExtension
{
    public class ChromeExtensionHandler : IRequestHandler<ChromeExtensionRequest, ChromeExtensionResponse>
    {
        private readonly IShScrapingService _shScrapingService;
        private readonly ICustomerOwnedPropertyWriteRepository _customerOwnedPropertyWriteRepository;
        private readonly ICustomerOwnedPropertyReadRepository _customerOwnedPropertyReadRepository;
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;
        private readonly IPropertyListingDetailWriteRepository _propertyListingDetailWriteRepository;
        private readonly IPropertyListingDetailReadRepository _propertyListingDetailReadRepository;
        private readonly IPropertyListingPhotoWriteRepository _propertyListingPhotoWriteRepository;
        private readonly ICityReadRepository _cityReadRepository;
        private readonly IDistrictReadRepository _districtReadRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ChromeExtensionHandler(IShScrapingService shScrapingService, ICustomerOwnedPropertyWriteRepository customerOwnedPropertyWriteRepository, ICustomerReadRepository customerReadRepository, IPropertyListingDetailWriteRepository propertyListingDetailWriteRepository, IPropertyListingDetailReadRepository propertyListingDetailReadRepository, IPropertyListingPhotoWriteRepository propertyListingPhotoWriteRepository, ICustomerWriteRepository customerWriteRepository, ICityReadRepository cityReadRepository, IDistrictReadRepository districtReadRepository, ICustomerOwnedPropertyReadRepository customerOwnedPropertyReadRepository, IHttpContextAccessor httpContextAccessor)
        {
            _shScrapingService = shScrapingService;
            _customerOwnedPropertyWriteRepository = customerOwnedPropertyWriteRepository;
            _customerReadRepository = customerReadRepository;
            _propertyListingDetailWriteRepository = propertyListingDetailWriteRepository;
            _propertyListingDetailReadRepository = propertyListingDetailReadRepository;
            _propertyListingPhotoWriteRepository = propertyListingPhotoWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _cityReadRepository = cityReadRepository;
            _districtReadRepository = districtReadRepository;
            _customerOwnedPropertyReadRepository = customerOwnedPropertyReadRepository;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<ChromeExtensionResponse> Handle(ChromeExtensionRequest request, CancellationToken cancellationToken)
        {
            PropertyListingDetail propertyListingDetail = await _shScrapingService.GetListingDetail(request.Url, request.OuterHTML, Path.Combine("ShScraping"));

            PropertyListingDetail pldResult = await _propertyListingDetailReadRepository.GetSingleAsync(x => x.Id == propertyListingDetail.Id);
            if (pldResult is null)
            {
                pldResult = await _propertyListingDetailWriteRepository.AddAndSaveAsync(propertyListingDetail);
                await _propertyListingPhotoWriteRepository.AddRangeAsync(propertyListingDetail.PropertyListingPhotos.AsEnumerable());
                await _propertyListingPhotoWriteRepository.SaveAsync();
            }

            var cospResult = await _customerOwnedPropertyReadRepository.GetSingleAsync(x => x.PropertyListingDetailId == pldResult.Id && x.IsDeleted == false);
            if (cospResult is not null)
                return new ChromeExtensionResponse()
                {
                    Message = "Aynı ilan birden çok kullanıcıya kayıt edilemez",
                    Success = false
                };


            Domain.Entities.Customer customer;
            if (request.CustomerId != null || request.CustomerId > 0)
            {
                customer = await _customerReadRepository.GetByIdAsync((uint)request.CustomerId);
                if (customer is null)
                    return new ChromeExtensionResponse()
                    {
                        Message = "Customer bulunamadı",
                        Success = false
                    };
            }
            else
            {
                string[] fullname = propertyListingDetail.ListingUserName.Split(" ");
                var numbers = propertyListingDetail.ListingPhoneNumbers.Split(" ").Where(x => x.StartsWith("05")).ToArray();

                customer = await _customerReadRepository.GetSingleAsync(x => x.MobileNumber == numbers[0] || x.MobileNumber2 == numbers[0]);

                if (customer == null && numbers.Length > 1)
                    customer = await _customerReadRepository.GetSingleAsync(x => x.MobileNumber == numbers[1] || x.MobileNumber2 == numbers[1]);

                if (customer == null)
                {
                    uint loginUserId = uint.Parse(_httpContextAccessor.HttpContext?.User?.Claims?.FirstOrDefault(e => ClaimTypes.NameIdentifier == e.Type)?.Value ?? "0");
                    var city = await _cityReadRepository.GetSingleAsync(x => x.Name == propertyListingDetail.City.ToUpper(CultureInfo.CreateSpecificCulture("tr-TR")));
                    var district = await _districtReadRepository.GetSingleAsync(x => x.Name == propertyListingDetail.District.ToUpper(CultureInfo.CreateSpecificCulture("tr-TR")));
                    customer = await _customerWriteRepository.AddAndSaveAsync(new Domain.Entities.Customer()
                    {
                        FirstName = fullname[0] + (fullname.Length > 2 ? " "+fullname[1] : ""),
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
            
            cospResult = await _customerOwnedPropertyWriteRepository.AddAndSaveAsync(new Domain.Entities.CustomerOwnedProperty()
            {
                CustomerId = customer.Id,
                PropertyListingDetailId = pldResult.Id,
                ShLink = request.Url
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
