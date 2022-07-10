using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Agent.UpdateAgent
{
    public class UpdateAgentHandler : IRequestHandler<UpdateAgentRequest, UpdateAgentResponse>
    {
        private readonly IAgentReadRepository _agentReadRepository;
        private readonly IAgentWriteRepository _agentWriteRepository;

        public UpdateAgentHandler(IAgentWriteRepository agentWriteRepository, IAgentReadRepository agentReadRepository)
        {
            _agentWriteRepository = agentWriteRepository;
            _agentReadRepository = agentReadRepository;
        }

        public async Task<UpdateAgentResponse> Handle(UpdateAgentRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Agent agent = await _agentReadRepository.GetByIdAsync(request.UserId);
            if(agent is null)
                return new UpdateAgentResponse()
                {
                    Message = "Agent Bulunamadı",
                    Success = false
                };
            agent.IsActive = request.IsActive == default ? agent.IsActive : request.IsActive;
            agent.YoutubeProfileUrl = request.YoutubeProfileUrl == default ? agent.YoutubeProfileUrl : request.YoutubeProfileUrl;
            agent.FacebookUrl = request.FacebookUrl == default ? agent.FacebookUrl : request.FacebookUrl;
            agent.ViewPhoneNumber = request.ViewPhoneNumber == default ? agent.ViewPhoneNumber : request.ViewPhoneNumber;
            agent.InstagramUrl = request.InstagramUrl == default ? agent.InstagramUrl : request.InstagramUrl;
            agent.CompanyId = request.CompanyId == default ? agent.CompanyId : request.CompanyId;
            agent.Description = request.Description == default ? agent.Description : request.Description;
            agent.JobTitleId = request.JobTitleId == default ? agent.JobTitleId : request.JobTitleId;
            agent.ViewMobileNumber = request.ViewMobileNumber == default ? agent.ViewMobileNumber : request.ViewMobileNumber;
            agent.LinkedinUrl = request.LinkedinUrl == default ? agent.LinkedinUrl : request.LinkedinUrl;
            agent.TwitterUrl = request.TwitterUrl == default ? agent.TwitterUrl : request.TwitterUrl;
            var result = await _agentWriteRepository.SaveAsync();
            if(result <=0)
                return new UpdateAgentResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };
            return new UpdateAgentResponse()
            {
                Message = "Agent güncellendi",
                Success = true
            };

        }
    }
}
