using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Agent.DeleteAgent
{
    public class DeleteAgentRequest : IRequest<DeleteAgentResponse>
    {
        public uint UserId { get; set; }
    }
}
