using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.OperationClaim.GetAllOperationClaim
{
    public class GetAllOperationClaimHandler : IRequestHandler<GetAllOperationClaimRequest, GetAllOperationClaimResponse>
    {
        private readonly IOperationClaimReadRepository _operationClaimReadRepository;

        public GetAllOperationClaimHandler(IOperationClaimReadRepository operationClaimReadRepository)
        {
            _operationClaimReadRepository = operationClaimReadRepository;
        }

        public async Task<GetAllOperationClaimResponse> Handle(GetAllOperationClaimRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.Identity.OperationClaim> operationClaims = _operationClaimReadRepository.GetAll(false);
            return await Task.FromResult(new GetAllOperationClaimResponse()
            {
                Data = operationClaims,
                Message = $"{operationClaims.Count()} adet data getirildi",
                Success = true
            });
        }
    }
}
