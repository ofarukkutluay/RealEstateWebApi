using MediatR;

namespace RealEstateWebApi.Application.Features.Queries.PropertyListingPhoto.ZipPropertyListingPhotoByOuterPropertyListingId;

public class ZipPropertyListingPhotoByOuterPropertyListingIdRequest : IRequest<ZipPropertyListingPhotoByOuterPropertyListingIdResponse>
{
    public string OuterPropertyListingId { get; set; }  

}
