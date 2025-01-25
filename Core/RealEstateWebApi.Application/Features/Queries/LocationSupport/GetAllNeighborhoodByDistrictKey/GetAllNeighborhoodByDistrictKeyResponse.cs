using RealEstateWebApi.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.LocationSupport.GetAllNeighborhoodByDistrictKey
{
    public class GetAllNeighborhoodByDistrictKeyResponse : DataResult<IEnumerable<Domain.Entities.Neighborhood>>
    {
    }
}
