

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class PropertyWriteRepository : WriteRepository<Property, RealEstateWebApiDbContext>, IPropertyWriteRepository
    {
        public PropertyWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
