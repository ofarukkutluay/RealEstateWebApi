using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.UserOperationClaim.CreateUserOperationClaim
{
    public class CreateUserOperationClaimHandler : IRequestHandler<CreateUserOperationClaimRequest, CreateUserOperationClaimResponse>
    {
        private readonly IUserOperationClaimReadRepository _userOperationClaimReadRepository;
        private readonly IUserOperationClaimWriteRepository _userOperationClaimWriteRepository;
        private readonly IMapper _mapper;
        public CreateUserOperationClaimHandler(IUserOperationClaimReadRepository userOperationClaimReadRepository, IUserOperationClaimWriteRepository userOperationClaimWriteRepository, IMapper mapper)
        {
            _userOperationClaimReadRepository = userOperationClaimReadRepository;
            _userOperationClaimWriteRepository = userOperationClaimWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateUserOperationClaimResponse> Handle(CreateUserOperationClaimRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Identity.UserOperationClaim userOperationClaim = await _userOperationClaimReadRepository.GetSingleAsync(e=>e.UserId == request.UserId && e.OperationClaimId == request.OperationClaimId);
            if(userOperationClaim != null)
                return new CreateUserOperationClaimResponse()
                {
                    Message = "Bu user için bu claim zaten kayıtlıdır",
                    Success = false
                };
            userOperationClaim = _mapper.Map<Domain.Entities.Identity.UserOperationClaim>(request);
            var result = await _userOperationClaimWriteRepository.AddAndSaveAsync(userOperationClaim);
            if(result == null)
                return new CreateUserOperationClaimResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new CreateUserOperationClaimResponse()
            {
                Success = true,
                Message = $"{result.Id} id ile kayıt edildi."
            };
        }
    }
}
