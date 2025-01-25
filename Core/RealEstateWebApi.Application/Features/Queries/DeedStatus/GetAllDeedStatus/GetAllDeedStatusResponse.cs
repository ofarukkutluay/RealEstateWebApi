using RealEstateWebApi.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.DeedStatus.GetAllDeedStatus
{
    public class GetAllDeedStatusResponse : DataResult<IEnumerable<Domain.Entities.DeedStatus>>
    {
    }
}
