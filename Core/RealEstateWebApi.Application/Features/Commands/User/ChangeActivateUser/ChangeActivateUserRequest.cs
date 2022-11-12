using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.User.ChangeActivateUser
{
    public class ChangeActivateUserRequest : IRequest<ChangeActivateUserResponse>
    {
        public string TempPass { get; set; }
        public uint UserId { get; set; }
        public bool Activate { get; set; }
    }
}
