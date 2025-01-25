using RealEstateWebApi.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.LocationSupport.GetAllDistrictByCitykey
{
    public class GetAllDistrictByCityKeyResponse : DataResult<IEnumerable<Domain.Entities.District>>
    {
    }
}
