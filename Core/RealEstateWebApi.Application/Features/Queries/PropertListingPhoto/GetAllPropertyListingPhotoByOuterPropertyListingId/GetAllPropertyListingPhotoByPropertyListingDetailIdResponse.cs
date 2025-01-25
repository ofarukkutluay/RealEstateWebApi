using RealEstateWebApi.Application.Results;
using RealEstateWebApi.Domain.Entities;

namespace RealEstateWebApi.Application.Features.Queries.PropertyListingPhoto.GetPropertyListingPhotoByOuterPropertyListingId;

public class GetAllPropertyListingPhotoByOuterPropertyListingIdResponse : DataResult<IEnumerable<Domain.Entities.PropertyListingPhoto>>
{

}
