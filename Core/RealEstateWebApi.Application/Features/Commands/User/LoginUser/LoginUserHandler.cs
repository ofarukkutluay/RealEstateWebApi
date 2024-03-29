﻿using MediatR;
using Microsoft.Extensions.Configuration;
using RealEstateWebApi.Application.Abstractions.Token;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.DTOs.TokenOperation;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Application.Security.Hashing;



namespace RealEstateWebApi.Application.Features.Commands.User.LoginUser
{
    public class LoginUserHandler : IRequestHandler<LoginUserRequest, LoginUserResponse>
    {
        private readonly IUserReadRepository _userReadRepository;
        private readonly ITokenHandler _tokenHandler;
        private readonly IUserLoginReadRepository _userLoginReadRepository;
        private readonly IUserLoginWriteRepository _userLoginWriteRepository;
        private readonly IFileReadRepository _fileReadRepository;
        private readonly IConfiguration _configuration;

        public LoginUserHandler(IUserReadRepository userReadRepository, ITokenHandler tokenHandler, IUserLoginWriteRepository userLoginWriteRepository, IUserLoginReadRepository userLoginReadRepository, IFileReadRepository fileReadRepository, IConfiguration configuration)
        {
            _userReadRepository = userReadRepository;
            _tokenHandler = tokenHandler;
            _userLoginWriteRepository = userLoginWriteRepository;
            _userLoginReadRepository = userLoginReadRepository;
            _fileReadRepository = fileReadRepository;
            _configuration = configuration;
        }

        public async Task<LoginUserResponse> Handle(LoginUserRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Identity.User user = await _userReadRepository.GetSingleAsync(e=>e.Email == request.Username || e.MobileNumber == request.Username);
            if (user == null)
                return new LoginUserResponse()
                {
                    Message = "Kullanıcı bulunamadı!",
                    Success = false,
                };

            if (!HashingHelper.VerifyPasswordHash(request.Password,user.PassHash,user.PassSalt))
                return new LoginUserResponse()
                {
                    Message = "Şifre hatalı!",
                    Success = false
                };

            IEnumerable<Domain.Entities.Identity.OperationClaim> operationClaims = _userReadRepository.GetClaims(user);
            if (!operationClaims.Any() || !user.IsActive)
                return new LoginUserResponse()
                {
                    Message = "Kullanıcının hiçbir yetkisi yok yada aktif değil",
                    Success = false
                };

            UserDto userDto = _userReadRepository.GetUserDtoById(user.Id);
            AccessToken accessToken = _tokenHandler.CreateToken<AccessToken>(userDto, operationClaims);

            IEnumerable<Domain.Entities.Identity.UserLogin> userLogins = _userLoginReadRepository.GetWhere(e=>e.UserId == user.Id);

            //todo Tüm kullanıcı login bilgisi silme işlemi daha sonra kaldırılıcak.
            //if(userLogins.Count()>5)
            //    _userLoginWriteRepository.RemoveRange(userLogins);

            await _userLoginWriteRepository.AddAsync(new Domain.Entities.Identity.UserLogin()
            {
                UserId = user.Id,
                RefreshToken = accessToken.RefreshToken,
                RefreshTokenExpireDate = accessToken.Expiration.AddMinutes(5)
            });

            await _userLoginWriteRepository.SaveAsync();

            return new LoginUserResponse()
            {
                Data = accessToken,
                Success = true,
                Message = "Giriş yapıldı."
            };

        }
    }
}
