using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.UserOperationClaim.DeleteUserOperationClaim
{
    public class DeleteUserOperationClaimHandler : IRequestHandler<DeleteUserOperationClaimRequest, DeleteUserOperationClaimResponse>
    {
        private readonly IUserOperationClaimReadRepository _userOperationClaimReadRepository;
        private readonly IUserOperationClaimWriteRepository _userOperationClaimWriteRepository;

        public DeleteUserOperationClaimHandler(IUserOperationClaimWriteRepository userOperationClaimWriteRepository, IUserOperationClaimReadRepository userOperationClaimReadRepository)
        {
            _userOperationClaimWriteRepository = userOperationClaimWriteRepository;
            _userOperationClaimReadRepository = userOperationClaimReadRepository;
        }

        public async Task<DeleteUserOperationClaimResponse> Handle(DeleteUserOperationClaimRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Identity.UserOperationClaim userOperationClaim = await _userOperationClaimReadRepository.GetSingleAsync(e=>e.UserId == request.UserId && e.OperationClaimId == request.OperationClaimId);
            if(userOperationClaim == null)
                return new DeleteUserOperationClaimResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            await _userOperationClaimWriteRepository.RemoveAsync(userOperationClaim.Id);
            var result = await _userOperationClaimWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteUserOperationClaimResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };
            return new DeleteUserOperationClaimResponse()
            {
                Message = "Kayıt silindi",
                Success = true
            };
        }
    }
}
