using MediatR;
using RealEstateWebApi.Application.Abstractions.Security;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Application.Security.Hashing;

namespace RealEstateWebApi.Application.Features.Commands.User.CreateAndChangePasswordUser
{
    public class CreateAndChangePasswordUserHandler : IRequestHandler<CreateAndChangePasswordUserRequest, CreateAndChangePasswordUserResponse>
    {
        private readonly IUserWriteRepository _userWriteRepository;
        private readonly IUserReadRepository _userReadRepository;
        private readonly ITemporaryPassService _temporaryPassService;

        public CreateAndChangePasswordUserHandler(IUserReadRepository userReadRepository, IUserWriteRepository userWriteRepository, ITemporaryPassService temporaryPassService)
        {
            _userReadRepository = userReadRepository;
            _userWriteRepository = userWriteRepository;
            _temporaryPassService = temporaryPassService;
        }

        public async Task<CreateAndChangePasswordUserResponse> Handle(CreateAndChangePasswordUserRequest request, CancellationToken cancellationToken)
        {
            if(!_temporaryPassService.Check(request.TempPass))
                return new CreateAndChangePasswordUserResponse()
                {
                    Message = "Admin şifresi yanlış",
                    Success = false
                };

            Domain.Entities.Identity.User user = await _userReadRepository.GetByIdAsync(request.UserId);
            if (user == null)
                return new CreateAndChangePasswordUserResponse()
                {
                    Message = "Kullanıcı bulunamadı",
                    Success = false
                };

            string returnPass = String.Empty;
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {

                int value = random.Next(10);
                returnPass += value.ToString();
            }

            HashingHelper.CreatePasswordHash(returnPass, out byte[] passHash, out byte[] passSalt);
            user.PassHash = passHash;
            user.PassSalt = passSalt;
            var result = await _userWriteRepository.SaveAsync();
            if (result < 0)
                return new CreateAndChangePasswordUserResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new CreateAndChangePasswordUserResponse()
            {
                Data = returnPass,
                Message = "Şifre değiştirildi",
                Success = true
            };


        }
    }
}
