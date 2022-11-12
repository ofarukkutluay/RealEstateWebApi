using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.UserOperationClaim.GetAllUserOperationClaimByUserId
{
    public class GetAllUserOperationClaimByUserIdHandler : IRequestHandler<GetAllUserOperationClaimByUserIdRequest, GetAllUserOperationClaimByUserIdResponse>
    {
        private readonly IUserOperationClaimReadRepository _userOperationClaimReadRepository;

        public GetAllUserOperationClaimByUserIdHandler(IUserOperationClaimReadRepository userOperationClaimReadRepository)
        {
            _userOperationClaimReadRepository = userOperationClaimReadRepository;
        }

        public async Task<GetAllUserOperationClaimByUserIdResponse> Handle(GetAllUserOperationClaimByUserIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.Identity.UserOperationClaim> userOperationClaims = _userOperationClaimReadRepository.GetWhere(e=>e.UserId==request.UserId);
            return await Task.FromResult(new GetAllUserOperationClaimByUserIdResponse()
            {
                Data = userOperationClaims,
                Message = $"{userOperationClaims.Count()} adet data getirildi",
                Success = true
            });
        }
    }
}
