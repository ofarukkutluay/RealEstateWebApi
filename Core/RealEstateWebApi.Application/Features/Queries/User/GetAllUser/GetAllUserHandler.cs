using MediatR;
using Microsoft.AspNetCore.Http;
using RealEstateWebApi.Application.Abstractions.Security;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.User.GetAllUser
{
    public class GetAllUserHandler : IRequestHandler<GetAllUserRequest, GetAllUserResponse>
    {
        private readonly IUserReadRepository _userReadRepository;
        private ITemporaryPassService _temporaryPassService;

        public GetAllUserHandler(IUserReadRepository userReadRepository, ITemporaryPassService temporaryPassService)
        {
            _userReadRepository = userReadRepository;
            _temporaryPassService = temporaryPassService;
        }

        public async Task<GetAllUserResponse> Handle(GetAllUserRequest request, CancellationToken cancellationToken)
        {
            
            if (!_temporaryPassService.Check(request.TempPass))
                return await Task.FromResult(new GetAllUserResponse()
                {
                    Message = "Şifre hatalı",
                    Success = false
                });

            IEnumerable<UserDto> users = _userReadRepository.GetAllUserDto();

            return await Task.FromResult(new GetAllUserResponse()
            {
                Message = "Tüm Data getirldi",
                Success = true,
                Data = users
            });
        }
    }
}
