
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class StreetReadRepository : ReadRepository<Street, RealEstateWebApiDbContext>, IStreetReadRepository
    {
        public StreetReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
