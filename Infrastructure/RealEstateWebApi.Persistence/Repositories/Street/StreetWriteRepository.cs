

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class StreetWriteRepository : WriteRepository<Street, RealEstateWebApiDbContext>, IStreetWriteRepository
    {
        public StreetWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
