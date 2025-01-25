using MediatR;
using RealEstateWebApi.Application.Repositories;

namespace RealEstateWebApi.Application.Features.Queries.PropertyListingPhoto.ZipPropertyListingPhotoByOuterPropertyListingId;

public class ZipPropertyListingPhotoByOuterPropertyListingIdHandler : IRequestHandler<ZipPropertyListingPhotoByOuterPropertyListingIdRequest, ZipPropertyListingPhotoByOuterPropertyListingIdResponse>
{
    private readonly IPropertyListingPhotoReadRepository _propertyListingPhotoReadRepository;
    private readonly IZipService _zipService;

    public ZipPropertyListingPhotoByOuterPropertyListingIdHandler(IPropertyListingPhotoReadRepository propertyListingPhotoReadRepository, IZipService zipService)
    {
        _propertyListingPhotoReadRepository = propertyListingPhotoReadRepository;
        _zipService = zipService;
    }

    public async Task<ZipPropertyListingPhotoByOuterPropertyListingIdResponse> Handle(ZipPropertyListingPhotoByOuterPropertyListingIdRequest request, CancellationToken cancellationToken)
    {
        Domain.Entities.PropertyListingPhoto propertyListingPhoto = await _propertyListingPhotoReadRepository.GetSingleAsync(x => x.OuterPropertyListingId == request.OuterPropertyListingId);

        byte[] resultFile = _zipService.ZipFiles(propertyListingPhoto.Path);


        return new ZipPropertyListingPhotoByOuterPropertyListingIdResponse
        {
            Success = true,
            Message = "Ziplendi",
            Data = resultFile
        };
    }
}
