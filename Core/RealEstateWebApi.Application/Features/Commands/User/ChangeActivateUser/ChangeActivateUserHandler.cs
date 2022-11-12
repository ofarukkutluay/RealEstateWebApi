using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.User.ChangeActivateUser
{
    public class ChangeActivateUserHandler : IRequestHandler<ChangeActivateUserRequest, ChangeActivateUserResponse>
    {
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserWriteRepository _userWriteRepository;
        private readonly IUserOperationClaimReadRepository _userOperationClaimReadRepository;
        private readonly ILocalDbContext _localDbContext;

        public ChangeActivateUserHandler(IUserWriteRepository userWriteRepository, IUserReadRepository userReadRepository, ILocalDbContext localDbContext, IUserOperationClaimReadRepository userOperationClaimReadRepository)
        {
            _userWriteRepository = userWriteRepository;
            _userReadRepository = userReadRepository;
            _localDbContext = localDbContext;
            _userOperationClaimReadRepository = userOperationClaimReadRepository;
        }

        public async Task<ChangeActivateUserResponse> Handle(ChangeActivateUserRequest request, CancellationToken cancellationToken)
        {
            if (request.TempPass != _localDbContext.TemporaryPass.First().Content)
                return new ChangeActivateUserResponse()
                {
                    Message = "Şifre hatalı",
                    Success = false
                };

            Domain.Entities.Identity.User user = await _userReadRepository.GetByIdAsync(request.UserId);
            if (user == null)
                return new ChangeActivateUserResponse
                {
                    Message = "Kullanıcı bulunamadı",
                    Success = false
                };

            if (!request.Activate)
            {
                var claims = _userOperationClaimReadRepository.GetWhere(x => x.UserId == user.Id);
                if (claims.Where(x => x.OperationClaimId == 1).Any())
                {
                    return new ChangeActivateUserResponse()
                    {
                        Message = "Admin kullanıcı deaktif edilemez",
                        Success = false
                    };
                }
            }


            user.IsActive = request.Activate;
            var result = await _userWriteRepository.SaveAsync();
            if (result < 0)
                return new ChangeActivateUserResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new ChangeActivateUserResponse()
            {
                Message = "Başarılı şekilde aktivasyon durumu değiştirildi",
                Success = true
            };
        }
    }
}
