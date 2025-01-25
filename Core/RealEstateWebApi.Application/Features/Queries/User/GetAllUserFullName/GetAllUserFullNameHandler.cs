using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.User.GetAllUserFullName
{
    public class GetAllUserFullNameHandler : IRequestHandler<GetAllUserFullNameRequest, GetAllUserFullNameResponse>
    {
        private readonly IUserReadRepository _userReadRepository;

        public GetAllUserFullNameHandler(IUserReadRepository userReadRepository)
        {
            _userReadRepository = userReadRepository;
        }

        public Task<GetAllUserFullNameResponse> Handle(GetAllUserFullNameRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<UserDto> userDtos = _userReadRepository.GetAllUserFullNameDto();
            return Task.FromResult(new GetAllUserFullNameResponse()
            {
                Data= userDtos,
                Message = $"{userDtos.Count()} adet data getirildi",
                Success = true
            });

        }
    }
}
