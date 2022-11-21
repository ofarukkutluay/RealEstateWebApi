using MediatR;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Application.Results;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Agent.GetAllAgentByCompanyId
{
    public class GetAllAgentByCompanyIdHandler : IRequestHandler<GetAllAgentByCompanyIdRequest, GetAllAgentByCompanyIdResponse>
    {
        private readonly IAgentReadRepository _agentReadRepository;
        public GetAllAgentByCompanyIdHandler(IAgentReadRepository agentReadRepository)
        {
            _agentReadRepository = agentReadRepository;
        }

        public async Task<GetAllAgentByCompanyIdResponse> Handle(GetAllAgentByCompanyIdRequest request, CancellationToken cancellationToken)
        {

            IEnumerable<Domain.Entities.Agent> agent = await Task.Run(() =>
            {
                return _agentReadRepository.GetWhere(x => x.CompanyId == request.CompanyId && x.IsDeleted == false).AsEnumerable().OrderByDescending(x=>x.Id);
            },cancellationToken);

            return new GetAllAgentByCompanyIdResponse()
            {
                Data = agent,
                Message = $"CompanyId : {request.CompanyId} 'nin agentları getirildi.",
                Success =true
            };
        }
    }
}
