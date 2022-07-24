using RealEstateWebApi.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.CustomerSearchShortProperty.GetAllCustomerSearchShortPropertyByCustomerId
{
    public class GetAllCustomerSearchShortPropertyByCustomerIdResponse : DataResult<IEnumerable<Domain.Entities.CustomerSearchShortProperty>>
    {
    }
}
