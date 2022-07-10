using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.UserLogin.DeleteUserlogin
{
    public class DeleteUserLoginHandler : IRequestHandler<DeleteUserLoginRequest, DeleteUserLoginResponse>
    {
        private readonly IUserLoginReadRepository _userLoginReadRepository;
        private readonly IUserLoginWriteRepository _userLoginWriteRepository;

        public DeleteUserLoginHandler(IUserLoginWriteRepository userLoginWriteRepository, IUserLoginReadRepository userLoginReadRepository)
        {
            _userLoginWriteRepository = userLoginWriteRepository;
            _userLoginReadRepository = userLoginReadRepository;
        }

        public async Task<DeleteUserLoginResponse> Handle(DeleteUserLoginRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Identity.UserLogin userLogin = await _userLoginReadRepository.GetByIdAsync(request.Id);
            if(userLogin == null)
                return new DeleteUserLoginResponse()
                {
                    Message = "Login bilgisi bulunamadı",
                    Success = false
                };

            await _userLoginWriteRepository.RemoveAsync(request.Id);
            var result = await _userLoginWriteRepository.SaveAsync();
            if(result <0)
                return new DeleteUserLoginResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };

            return new DeleteUserLoginResponse()
            {
                Message = "Login silindi",
                Success = true
            };
        }
    }
}
