using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Agent.DeleteAgent
{
    public class DeleteAgentHandler : IRequestHandler<DeleteAgentRequest, DeleteAgentResponse>
    {
        private readonly IAgentReadRepository _agentReadRepository;
        private readonly IAgentWriteRepository _agentWriteRepository;

        public DeleteAgentHandler(IAgentReadRepository agentReadRepository, IAgentWriteRepository agentWriteRepository)
        {
            _agentReadRepository = agentReadRepository;
            _agentWriteRepository = agentWriteRepository;
        }

        public async Task<DeleteAgentResponse> Handle(DeleteAgentRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Agent agent = await _agentReadRepository.GetByIdAsync(request.UserId);
            if(agent == null)
                return new DeleteAgentResponse()
                {
                    Message = "Agent bulunamadı",
                    Success = false
                };

            agent.IsDeleted = true;
            var result = await _agentWriteRepository.SaveAsync();
            if(result<=0)
                return new DeleteAgentResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new DeleteAgentResponse()
            {
                Message = "Agent silindi",
                Success = true
            };
        }
    }
}
