using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.UserOperationClaim.GetAllUserOperationClaimByOperationClaimId
{
    public class GetAllUserOperationClaimByOperationClaimIdRequest : IRequest<GetAllUserOperationClaimByOperationClaimIdResponse>
    {
        public uint OperationClaimId { get; set; }
    }
}
