using AutoMapper;
using MediatR;
using Microsoft.Extensions.Configuration;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.User.GetUserByUserId
{
    public class GetUserByUserIdHandler : IRequestHandler<GetUserByUserIdRequest, GetUserByUserIdResponse>
    {
        private readonly IUserReadRepository _userReadRepository;
        private readonly IFileReadRepository _fileReadRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public GetUserByUserIdHandler(IUserReadRepository userReadRepository, IMapper mapper, IFileReadRepository fileReadRepository, IConfiguration configuration)
        {
            _userReadRepository = userReadRepository;
            _mapper = mapper;
            _fileReadRepository = fileReadRepository;
            _configuration = configuration;
        }

        public async Task<GetUserByUserIdResponse> Handle(GetUserByUserIdRequest request, CancellationToken cancellationToken)
        {
            UserDto userDto = _userReadRepository.GetUserDtoById(request.Id);
            if (userDto is null)
                return new GetUserByUserIdResponse()
                {
                    Message = "Kullanıcı bulunamadı",
                    Success = false,
                };

            userDto.ProfileImgFilePath = $"{_configuration["BaseStorageUrl"]}/{userDto.ProfileImgFilePath}";

            return new GetUserByUserIdResponse()
            {
                Message = "Data getirildi",
                Success = true,
                Data = userDto
            };

        }
    }
}
