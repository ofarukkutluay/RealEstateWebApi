

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class PropertyCategoryReadRepository : ReadRepository<PropertyCategory, RealEstateWebApiDbContext>, IPropertyCategoryReadRepository
    {
        public PropertyCategoryReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
