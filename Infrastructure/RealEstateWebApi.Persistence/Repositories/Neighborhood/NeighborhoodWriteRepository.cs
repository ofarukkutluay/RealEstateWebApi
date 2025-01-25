

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class NeighborhoodWriteRepository : WriteRepository<Neighborhood, RealEstateWebApiDbContext>, INeighborhoodWriteRepository
    {
        public NeighborhoodWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
