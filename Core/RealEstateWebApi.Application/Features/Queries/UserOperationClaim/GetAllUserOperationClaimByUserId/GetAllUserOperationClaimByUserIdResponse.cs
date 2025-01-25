using RealEstateWebApi.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.UserOperationClaim.GetAllUserOperationClaimByUserId
{
    public class GetAllUserOperationClaimByUserIdResponse : DataResult<IEnumerable<Domain.Entities.Identity.UserOperationClaim>>
    {
    }
}
