using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.UserLogin.GetAllUserLoginByUserId
{
    public class GetAllUserLoginByUserIdHandler : IRequestHandler<GetAllUserLoginByUserIdRequest, GetAllUserLoginByUserIdResponse>
    {
        private readonly IUserLoginReadRepository _userLoginReadRepository;

        public GetAllUserLoginByUserIdHandler(IUserLoginReadRepository userLoginReadRepository)
        {
            _userLoginReadRepository = userLoginReadRepository;
        }

        public async Task<GetAllUserLoginByUserIdResponse> Handle(GetAllUserLoginByUserIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.Identity.UserLogin> userLogins = _userLoginReadRepository.GetWhere(e=>e.UserId == request.UserId);
            return await Task.FromResult(new GetAllUserLoginByUserIdResponse()
            {
                Data = userLogins,
                Message = $"{userLogins.Count()} adet data getirildi.",
                Success = true
            });
        }
    }
}
