
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class PropertyStatusWriteRepository : WriteRepository<PropertyStatus, RealEstateWebApiDbContext>, IPropertyStatusWriteRepository
    {
        public PropertyStatusWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
