using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.UserLogin.GetAllUserLoginByUserId
{
    public class GetAllUserLoginByUserIdRequest : IRequest<GetAllUserLoginByUserIdResponse>
    {
        public uint UserId { get; set; }
    }
}
