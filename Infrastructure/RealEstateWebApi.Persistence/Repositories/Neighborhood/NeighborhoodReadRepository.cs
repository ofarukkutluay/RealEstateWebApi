

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class NeighborhoodReadRepository : ReadRepository<Neighborhood, RealEstateWebApiDbContext>, INeighborhoodReadRepository
    {
        public NeighborhoodReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
