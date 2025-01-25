
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class FrontReadRepository : ReadRepository<Front, RealEstateWebApiDbContext>, IFrontReadRepository
    {
        public FrontReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
