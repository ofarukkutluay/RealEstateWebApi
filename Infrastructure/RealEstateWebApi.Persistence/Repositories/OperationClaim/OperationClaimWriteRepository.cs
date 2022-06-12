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
    public class OperationClaimWriteRepository : WriteRepository<OperationClaim, RealEstateWebApiDbContext>, IOperationClaimWriteRepository
    {
        public OperationClaimWriteRepository(RealEstateWebApiDbContext context) : base(context)
        {
        }
    }
}
