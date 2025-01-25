

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class PropertyListingPhotoWriteRepository : WriteRepository<PropertyListingPhoto, RealEstateWebApiDbContext>, IPropertyListingPhotoWriteRepository
    {
        public PropertyListingPhotoWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
