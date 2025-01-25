

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class PropertyPhotoWriteRepository : WriteRepository<PropertyPhoto, RealEstateWebApiDbContext>, IPropertyPhotoWriteRepository
    {
        public PropertyPhotoWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
