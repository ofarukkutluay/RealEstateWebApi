using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Persistence.Contexts;


namespace RealEstateWebApi.Persistence.Repositories
{
    public class FileWriteRepository : WriteRepository<Domain.Entities.File, RealEstateWebApiDbContext> , IFileWriteRepository
    {
        public FileWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
