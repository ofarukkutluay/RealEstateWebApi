using MediatR;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Application.Security.Hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.User.ChangePasswordUser
{
    public class ChangePasswordUserHandler : IRequestHandler<ChangePasswordUserRequest, ChangePasswordUserResponse>
    {
        private readonly IUserReadRepository _userReadRepository;
        private readonly IUserWriteRepository _userWriteRepository;

        public ChangePasswordUserHandler(IUserReadRepository userReadRepository, IUserWriteRepository userWriteRepository)
        {
            _userReadRepository = userReadRepository;
            _userWriteRepository = userWriteRepository;
        }


        public async Task<ChangePasswordUserResponse> Handle(ChangePasswordUserRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Identity.User user = await _userReadRepository.GetByIdAsync(request.UserId);
            if (user is null)
                return new ChangePasswordUserResponse()
                {
                    Message = "kullanıcı bulunamadı",
                    Success = false
                };

            if (!HashingHelper.VerifyPasswordHash(request.OldPass, user.PassHash, user.PassSalt))
                return new ChangePasswordUserResponse()
                {
                    Message = "Eski şifre hatalı girdiniz",
                    Success = false
                };

            if (request.NewPass != request.ReNewPass)
                return new ChangePasswordUserResponse()
                {
                    Message = "Yeni girdiğiniz şifre ile tekrar girdiğiniz şifre aynı olmalıdır.",
                    Success = false
                };

            byte[] passHash, passSalt;
            HashingHelper.CreatePasswordHash(request.NewPass,out passHash, out passSalt);

            user.PassHash = passHash;
            user.PassSalt = passSalt;

            var result = await _userWriteRepository.SaveAsync();
            if (result < 0)
                return new ChangePasswordUserResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new ChangePasswordUserResponse()
            {
                Message = "Şifre değiştirildi",
                Success = true
            };
        }
    }
}
