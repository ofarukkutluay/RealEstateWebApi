

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class InternetTypeReadRepository : ReadRepository<InternetType, RealEstateWebApiDbContext>, IInternetTypeReadRepository
    {
        public InternetTypeReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
