
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class UsingStatusWriteRepository : WriteRepository<UsingStatus, RealEstateWebApiDbContext>, IUsingStatusWriteRepository
    {
        public UsingStatusWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
