using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities.Identity;
using RealEstateWebApi.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Persistence.Repositories
{
    public class UserOperationClaimReadRepository : ReadRepository<UserOperationClaim, RealEstateWebApiDbContext>, IUserOperationClaimReadRepository
    {
        public UserOperationClaimReadRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
