

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class PropertyTypeReadRepository : ReadRepository<PropertyType, RealEstateWebApiDbContext>, IPropertyTypeReadRepository
    {
        public PropertyTypeReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
