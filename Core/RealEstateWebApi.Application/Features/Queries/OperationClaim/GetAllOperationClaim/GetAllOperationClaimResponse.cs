using RealEstateWebApi.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.OperationClaim.GetAllOperationClaim
{
    public class GetAllOperationClaimResponse : DataResult<IEnumerable<Domain.Entities.Identity.OperationClaim>>
    {
    }
}
