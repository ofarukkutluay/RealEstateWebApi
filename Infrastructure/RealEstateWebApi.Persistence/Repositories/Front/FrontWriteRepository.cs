

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class FrontWriteRepository : WriteRepository<Front, RealEstateWebApiDbContext>, IFrontWriteRepository
    {
        public FrontWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
