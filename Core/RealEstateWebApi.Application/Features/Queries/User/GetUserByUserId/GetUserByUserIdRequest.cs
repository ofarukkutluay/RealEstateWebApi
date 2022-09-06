using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.User.GetUserByUserId
{
    public class GetUserByUserIdRequest : IRequest<GetUserByUserIdResponse>
    {
        public uint Id { get; set; }
    }
}
