

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class PropertyTypeWriteRepository : WriteRepository<PropertyType, RealEstateWebApiDbContext>, IPropertyTypeWriteRepository
    {
        public PropertyTypeWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
