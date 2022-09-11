using MediatR;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Application.Security.Hashing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.User.RegisterUser
{
    public class RegisterUserHandler : IRequestHandler<RegisterUserRequest, RegisterUserResponse>
    {
        private readonly IUserWriteRepository _userWriteRepository;
        private readonly IUserReadRepository _userReadRepository;

        public RegisterUserHandler(IUserWriteRepository userWriteRepository, IUserReadRepository userReadRepository)
        {
            _userWriteRepository = userWriteRepository;
            _userReadRepository = userReadRepository;
        }

        public async Task<RegisterUserResponse> Handle(RegisterUserRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Identity.User user = await _userReadRepository.GetSingleAsync(e => e.Email == request.Email);
            if (user != null)
                return new RegisterUserResponse
                {
                    Message = "Giridiğiniz mail adresine ait kullanıcı bulunmaktadır.",
                    Success = false
                };

            request.MobileNumber = request.MobileNumber.Trim().Replace(" ", "");
            Regex regexMobilePhone = new Regex(@"^([5]{1})([0-9]{9})$");
            if (!regexMobilePhone.IsMatch(request.MobileNumber))
                return new RegisterUserResponse
                {
                    Message = "Giridiğiniz mobile numara hatalıdır.",
                    Success = false
                };

            user = await _userReadRepository.GetSingleAsync(e => e.MobileNumber == request.MobileNumber);
            if (user != null)
                return new RegisterUserResponse
                {
                    Message = "Giridiğiniz mobile numaraya ait kullanıcı bulunmaktadır.",
                    Success = false
                };

            byte[] passHash, passSalt;
            HashingHelper.CreatePasswordHash(request.Password, out passHash, out passSalt);

            

            user = new Domain.Entities.Identity.User()
            {
                Email = request.Email.Trim().ToLower(),
                FirstName = request.FirstName.Trim(),
                LastName = request.LastName.Trim(),
                MobileNumber = request.MobileNumber,
                BirthDate = request.BirthDate,
                PassHash = passHash,
                PassSalt = passSalt,
            };

            var addResult = await _userWriteRepository.AddAndSaveAsync(user);
            if (addResult==null)
            {
                return new RegisterUserResponse()
                {
                    Message = "Db ye kayıt olurken bir hata ile karşılaşıldı",
                    Success = false
                };
            }

            return new RegisterUserResponse
            {
                Message = $"{addResult.Id} id ile kullanıcı kayıt edildi",
                Success = true
            };
        }
    }
}
