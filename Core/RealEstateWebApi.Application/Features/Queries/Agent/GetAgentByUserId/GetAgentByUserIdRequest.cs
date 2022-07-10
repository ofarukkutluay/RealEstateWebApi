using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Agent.GetAgentByUserId
{
    public class GetAgentByUserIdRequest : IRequest<GetAgentByUserIdResponse>
    {
        public uint UserId { get; set; }
    }
}
