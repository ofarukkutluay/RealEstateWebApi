using MediatR;

namespace RealEstateWebApi.Application.Features.Queries.PropertyListingPhoto.GetPropertyListingPhotoByOuterPropertyListingId;

public class GetAllPropertyListingPhotoByOuterPropertyListingIdRequest : IRequest<GetAllPropertyListingPhotoByOuterPropertyListingIdResponse>
{
    public string OuterPropertyListingId { get; set; }

}
