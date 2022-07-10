using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.UserOperationClaim.CreateUserOperationClaim
{
    public class CreateUserOperationClaimRequest : IRequest<CreateUserOperationClaimResponse>
    {
        public uint UserId { get; set; }
        public uint OperationClaimId { get; set; }
    }
}
