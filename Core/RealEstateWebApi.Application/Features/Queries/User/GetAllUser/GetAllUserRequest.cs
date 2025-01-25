using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.User.GetAllUser
{
    public class GetAllUserRequest : IRequest<GetAllUserResponse>
    {
        public string TempPass { get; set; }
    }
}
