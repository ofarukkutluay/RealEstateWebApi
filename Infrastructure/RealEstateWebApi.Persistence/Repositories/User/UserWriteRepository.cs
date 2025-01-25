

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities.Identity;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class UserWriteRepository : WriteRepository<User, RealEstateWebApiDbContext>, IUserWriteRepository
    {
        public UserWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
