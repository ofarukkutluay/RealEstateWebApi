using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.UserLogin.GetAllUserLogin
{
    public class GetAllUserLoginHandler : IRequestHandler<GetAllUserLoginRequest, GetAllUserLoginResponse>
    {
        private readonly IUserLoginReadRepository _userLoginReadRepository;

        public GetAllUserLoginHandler(IUserLoginReadRepository userLoginReadRepository)
        {
            _userLoginReadRepository = userLoginReadRepository;
        }

        public async Task<GetAllUserLoginResponse> Handle(GetAllUserLoginRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.Identity.UserLogin> userLogins = _userLoginReadRepository.GetAll(false);
            return await Task.FromResult(new GetAllUserLoginResponse()
            {
                Data = userLogins,
                Message = $"{userLogins.Count()} adet data getirildi.",
                Success = true
            });
        }
    }
}
