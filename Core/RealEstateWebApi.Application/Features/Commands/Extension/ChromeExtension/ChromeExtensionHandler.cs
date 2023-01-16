using MediatR;
using RealEstateWebApi.Application.Abstractions.Scraping;
using RealEstateWebApi.Application.Abstractions.Storage;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;

namespace RealEstateWebApi.Application.Features.Commands.Extension.ChromeExtension
{
    public class ChromeExtensionHandler : IRequestHandler<ChromeExtensionRequest, ChromeExtensionResponse>
    {
        private readonly IShScrapingService _shScrapingService;
        private readonly ICustomerOwnedPropertyWriteRepository _customerOwnedShortPropertyWriteRepository;
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly IPropertyListingDetailWriteRepository _propertyListingDetailWriteRepository;
        private readonly IPropertyListingDetailReadRepository _propertyListingDetailReadRepository;
        private readonly IPropertyListingPhotoWriteRepository _propertyListingPhotoWriteRepository;
        public ChromeExtensionHandler(IShScrapingService shScrapingService, ICustomerOwnedPropertyWriteRepository customerOwnedShortPropertyWriteRepository, ICustomerReadRepository customerReadRepository, IPropertyListingDetailWriteRepository propertyListingDetailWriteRepository, IPropertyListingDetailReadRepository propertyListingDetailReadRepository, IPropertyListingPhotoWriteRepository propertyListingPhotoWriteRepository)
        {
            _shScrapingService = shScrapingService;
            _customerOwnedShortPropertyWriteRepository = customerOwnedShortPropertyWriteRepository;
            _customerReadRepository = customerReadRepository;
            _propertyListingDetailWriteRepository = propertyListingDetailWriteRepository;
            _propertyListingDetailReadRepository = propertyListingDetailReadRepository;
            _propertyListingPhotoWriteRepository = propertyListingPhotoWriteRepository;
        }
        public async Task<ChromeExtensionResponse> Handle(ChromeExtensionRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Customer customer = await _customerReadRepository.GetByIdAsync(request.CustomerId);
            if (customer is null)
                return new ChromeExtensionResponse()
                {
                    Message = "Customer bulunamadı",
                    Success = false
                };



            PropertyListingDetail propertyListingDetail = await _shScrapingService.GetListingDetail(request.Url, request.OuterHTML, Path.Combine("ShScraping"));

            PropertyListingDetail searchPropertyListing = await _propertyListingDetailReadRepository.GetSingleAsync(x => x.Id == propertyListingDetail.Id);
            if (searchPropertyListing is not null)
                return new ChromeExtensionResponse()
                {
                    Message = "Aynı ilan birden çok kullanıcıya kayıt edilemez",
                    Success = false
                };

            var pldResult = await _propertyListingDetailWriteRepository.AddAndSaveAsync(propertyListingDetail);
            await _propertyListingPhotoWriteRepository.AddRangeAsync(propertyListingDetail.PropertyListingPhotos.AsEnumerable());
            await _propertyListingPhotoWriteRepository.SaveAsync();

            var cospResult = await _customerOwnedShortPropertyWriteRepository.AddAndSaveAsync(new Domain.Entities.CustomerOwnedProperty()
            {
                CustomerId = customer.Id,
                PropertyListingDetailId = pldResult.Id,
                ShLink = request.Url
            });


            return new ChromeExtensionResponse()
            {
                Message = "Kayıt başarılı!",
                Success = true
            };
        }
    }
}
