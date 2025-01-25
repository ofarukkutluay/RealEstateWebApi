
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class PropertyReadRepository : ReadRepository<Property, RealEstateWebApiDbContext>, IPropertyReadRepository
    {
        public PropertyReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
