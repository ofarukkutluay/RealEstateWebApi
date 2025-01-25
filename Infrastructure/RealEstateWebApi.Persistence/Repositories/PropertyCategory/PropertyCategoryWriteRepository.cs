
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class PropertyCategoryWriteRepository : WriteRepository<PropertyCategory, RealEstateWebApiDbContext>, IPropertyCategoryWriteRepository
    {
        public PropertyCategoryWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
