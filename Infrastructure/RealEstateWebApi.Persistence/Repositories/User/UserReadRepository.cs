

using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities.Identity;
using RealEstateWebApi.Persistence.Contexts;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class UserReadRepository : ReadRepository<User, RealEstateWebApiDbContext>, IUserReadRepository
    {
        private readonly RealEstateWebApiDbContext Context;
        public UserReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
            Context = context;
        }

        public IEnumerable<OperationClaim> GetClaims(User user)
        {
            var result = from operationClaim in Context.OperationClaims
                         join userOperationClaim in Context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                         where userOperationClaim.UserId == user.Id
                         select new OperationClaim
                         {
                             Id = operationClaim.Id,
                             Name = operationClaim.Name,
                             Alias = operationClaim.Alias,
                             CreatedDate = operationClaim.CreatedDate,
                             UpdatedDate = operationClaim.UpdatedDate,
                             IsActive = operationClaim.IsActive
                         };
            return result;
        }
    }
}
