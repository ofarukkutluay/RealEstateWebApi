using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Agent.GetAllAgentByCompanyId
{
    public class GetAllAgentByCompanyIdRequest : IRequest<GetAllAgentByCompanyIdResponse>
    {
        public uint CompanyId { get; set; }
    }
}
