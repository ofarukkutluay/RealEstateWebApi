using MediatR;
using RealEstateWebApi.Application.Repositories;

namespace RealEstateWebApi.Application.Features.Queries.PropertyListingPhoto.GetPropertyListingPhotoByOuterPropertyListingId;

public class GetAllPropertyListingPhotoByOuterPropertyListingIdHandler : IRequestHandler<GetAllPropertyListingPhotoByOuterPropertyListingIdRequest, GetAllPropertyListingPhotoByOuterPropertyListingIdResponse>
{
    private readonly IPropertyListingPhotoReadRepository _propertyListingPhotoReadRepository;
    public GetAllPropertyListingPhotoByOuterPropertyListingIdHandler(IPropertyListingPhotoReadRepository propertyListingPhotoReadRepository)
    {
        _propertyListingPhotoReadRepository = propertyListingPhotoReadRepository;
    }
    public async Task<GetAllPropertyListingPhotoByOuterPropertyListingIdResponse> Handle(GetAllPropertyListingPhotoByOuterPropertyListingIdRequest request, CancellationToken cancellationToken)
    {
        IEnumerable<Domain.Entities.PropertyListingPhoto> propertyListingPhotos = _propertyListingPhotoReadRepository.GetWhere(x => x.OuterPropertyListingId == request.OuterPropertyListingId);

        return new GetAllPropertyListingPhotoByOuterPropertyListingIdResponse{
            Success = true,
            Data = propertyListingPhotos,
            Message = "Tüm resimler getirildi",
            TotalDataCount = propertyListingPhotos.Count()
        };
    }
}
