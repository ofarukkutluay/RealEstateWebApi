using RealEstateWebApi.Application.Results;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Agent.GetAllAgentByCompanyId
{
    public class GetAllAgentByCompanyIdResponse : DataResult<IEnumerable<Domain.Entities.Agent>>
    {

    }
}
