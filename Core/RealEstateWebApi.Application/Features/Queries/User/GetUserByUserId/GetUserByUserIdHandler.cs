using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.User.GetUserByUserId
{
    public class GetUserByUserIdHandler : IRequestHandler<GetUserByUserIdRequest, GetUserByUserIdResponse>
    {
        private readonly IUserReadRepository _userReadRepository;
        private readonly IMapper _mapper;

        public GetUserByUserIdHandler(IUserReadRepository userReadRepository, IMapper mapper)
        {
            _userReadRepository = userReadRepository;
            _mapper = mapper;
        }

        public async Task<GetUserByUserIdResponse> Handle(GetUserByUserIdRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Identity.User user = await _userReadRepository.GetByIdAsync(request.Id);
            if (user is null)
                return new GetUserByUserIdResponse()
                {
                    Message = "Kullanıcı bulunamadı",
                    Success = false,
                };

            UserDto userDto = _mapper.Map<UserDto>(user);
            userDto.CreatedDate = userDto.CreatedDate.ToLocalTime();
            userDto.UpdatedDate = userDto.UpdatedDate != null ? userDto.UpdatedDate.Value.ToLocalTime() : null;

            return new GetUserByUserIdResponse()
            {
                Message = "Data getirildi",
                Success = true,
                Data = userDto
            };

        }
    }
}
