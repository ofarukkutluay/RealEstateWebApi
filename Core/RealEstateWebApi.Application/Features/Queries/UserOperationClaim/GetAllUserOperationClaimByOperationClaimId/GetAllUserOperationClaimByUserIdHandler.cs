using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.UserOperationClaim.GetAllUserOperationClaimByOperationClaimId
{
    public class GetAllUserOperationClaimByOperationClaimIdHandler : IRequestHandler<GetAllUserOperationClaimByOperationClaimIdRequest, GetAllUserOperationClaimByOperationClaimIdResponse>
    {
        private readonly IUserOperationClaimReadRepository _userOperationClaimReadRepository;

        public GetAllUserOperationClaimByOperationClaimIdHandler(IUserOperationClaimReadRepository userOperationClaimReadRepository)
        {
            _userOperationClaimReadRepository = userOperationClaimReadRepository;
        }

        public async Task<GetAllUserOperationClaimByOperationClaimIdResponse> Handle(GetAllUserOperationClaimByOperationClaimIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.Identity.UserOperationClaim> userOperationClaims = _userOperationClaimReadRepository.GetWhere(e=>e.OperationClaimId == request.OperationClaimId);
            return await Task.FromResult(new GetAllUserOperationClaimByOperationClaimIdResponse()
            {
                Data = userOperationClaims,
                Message = $"{userOperationClaims.Count()} adetdata getirildi",
                Success = true
            });
        }
    }
}
