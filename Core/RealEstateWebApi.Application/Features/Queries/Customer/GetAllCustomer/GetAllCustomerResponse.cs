using RealEstateWebApi.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomer
{
    public class GetAllCustomerResponse : DataResult<IEnumerable<Domain.Entities.Customer>>
    {
    }
}
