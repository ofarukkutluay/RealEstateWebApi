

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class PropertyListingPhotoReadRepository : ReadRepository<PropertyListingPhoto, RealEstateWebApiDbContext>, IPropertyListingPhotoReadRepository
    {
        public PropertyListingPhotoReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
