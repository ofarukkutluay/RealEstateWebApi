

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class PropertyPhotoReadRepository : ReadRepository<PropertyPhoto, RealEstateWebApiDbContext>, IPropertyPhotoReadRepository
    {
        public PropertyPhotoReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
