
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class JobTitleReadRepository : ReadRepository<JobTitle, RealEstateWebApiDbContext>, IJobTitleReadRepository
    {
        public JobTitleReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
