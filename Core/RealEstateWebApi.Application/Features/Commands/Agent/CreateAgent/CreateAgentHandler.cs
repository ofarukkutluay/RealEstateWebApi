using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Agent.CreateAgent
{
    public class CreateAgentHandler : IRequestHandler<CreateAgentRequest, CreateAgentResponse>
    {
        private readonly IAgentWriteRepository _agentWriteRepository;
        private readonly IMapper _mapper;

        public CreateAgentHandler(IAgentWriteRepository agentWriteRepository, IMapper mapper)
        {
            _agentWriteRepository = agentWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateAgentResponse> Handle(CreateAgentRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Agent agent = _mapper.Map<Domain.Entities.Agent>(request);
            await _agentWriteRepository.AddAsync(agent);
            await _agentWriteRepository.SaveAsync();
            return new CreateAgentResponse()
            {
                Message = "Agent eklendi",
                Success = true
            };
        }
    }
}
