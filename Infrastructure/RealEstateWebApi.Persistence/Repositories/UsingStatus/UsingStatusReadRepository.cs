

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class UsingStatusReadRepository : ReadRepository<UsingStatus, RealEstateWebApiDbContext>, IUsingStatusReadRepository
    {
        public UsingStatusReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
