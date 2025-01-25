using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.User.ChangePasswordUser
{
    public class ChangePasswordUserRequest : IRequest<ChangePasswordUserResponse>
    {
        public uint UserId { get; set; }
        public string OldPass { get; set; }
        public string NewPass { get; set; }
        public string ReNewPass { get; set; }
    }
}
