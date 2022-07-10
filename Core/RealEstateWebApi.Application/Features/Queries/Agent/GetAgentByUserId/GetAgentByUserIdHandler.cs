using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Agent.GetAgentByUserId
{
    public class GetAgentByUserIdHandler : IRequestHandler<GetAgentByUserIdRequest, GetAgentByUserIdResponse>
    {
        private readonly IAgentReadRepository _agentReadRepository;

        public GetAgentByUserIdHandler(IAgentReadRepository agentReadRepository)
        {
            _agentReadRepository = agentReadRepository;
        }

        public async Task<GetAgentByUserIdResponse> Handle(GetAgentByUserIdRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Agent agent = await _agentReadRepository.GetByIdAsync(request.UserId);

            return new GetAgentByUserIdResponse()
            {
                Message = "Agent getirildi",
                Success = true,
                Data = agent
            };
        }
    }
}
