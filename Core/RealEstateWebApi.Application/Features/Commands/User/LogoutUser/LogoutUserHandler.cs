using MediatR;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.User.LogoutUser
{
    public class LogoutUserHandler : IRequestHandler<LogoutUserRequest, LogoutUserResponse>
    {
        private readonly IUserLoginReadRepository _userLoginReadRepository;
        private readonly IUserLoginWriteRepository _userLoginWriteRepository;

        public LogoutUserHandler(IUserLoginWriteRepository userLoginWriteRepository, IUserLoginReadRepository userLoginReadRepository)
        {
            _userLoginWriteRepository = userLoginWriteRepository;
            _userLoginReadRepository = userLoginReadRepository;
        }

        public async Task<LogoutUserResponse> Handle(LogoutUserRequest request, CancellationToken cancellationToken)
        {
            UserLogin userLogin = await _userLoginReadRepository.GetSingleAsync(e=> e.UserId==request.UserId && e.RefreshToken == request.RefreshToken);
            if (userLogin == null)
                return new LogoutUserResponse()
                {
                    Message = "Login kullanıcı bulunamadı fakat logout oldu",
                    Success = true
                };

            await _userLoginWriteRepository.RemoveAsync(userLogin.Id);
            await _userLoginWriteRepository.SaveAsync();
            return new LogoutUserResponse()
            {
                Message = "Kullanıcı logout oldu.",
                Success = true,
            };
            
        }
    }
}
