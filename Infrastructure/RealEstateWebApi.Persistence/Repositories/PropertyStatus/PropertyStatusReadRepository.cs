

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class PropertyStatusReadRepository : ReadRepository<PropertyStatus, RealEstateWebApiDbContext>, IPropertyStatusReadRepository
    {
        public PropertyStatusReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
