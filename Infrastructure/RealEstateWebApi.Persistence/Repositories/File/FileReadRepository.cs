using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Persistence.Contexts;


namespace RealEstateWebApi.Persistence.Repositories
{
    public class FileReadRepository : ReadRepository<Domain.Entities.File, RealEstateWebApiDbContext> , IFileReadRepository
    {
        public FileReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
