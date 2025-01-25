using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.User.LogoutUser
{
    public class LogoutUserRequest : IRequest<LogoutUserResponse>
    {
        public uint UserId { get; set; }
        public string RefreshToken { get; set; }
    }
}
