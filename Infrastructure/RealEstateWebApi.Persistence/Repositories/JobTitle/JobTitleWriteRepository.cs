
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class JobTitleWriteRepository : WriteRepository<JobTitle, RealEstateWebApiDbContext>,IJobTitleWriteRepository
    {
        public JobTitleWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
