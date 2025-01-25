using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.UserOperationClaim.GetAllUserOperationClaimByUserId
{
    public class GetAllUserOperationClaimByUserIdRequest : IRequest<GetAllUserOperationClaimByUserIdResponse>
    {
        public uint UserId { get; set; }
    }
}
