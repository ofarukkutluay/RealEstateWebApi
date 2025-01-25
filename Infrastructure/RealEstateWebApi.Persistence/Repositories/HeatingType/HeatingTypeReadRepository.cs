

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class HeatingTypeReadRepository : ReadRepository<HeatingType, RealEstateWebApiDbContext>, IHeatingTypeReadRepository
    {
        public HeatingTypeReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
