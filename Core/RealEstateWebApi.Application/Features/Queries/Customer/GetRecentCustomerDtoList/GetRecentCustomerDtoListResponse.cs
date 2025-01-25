using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetRecentCustomerDtoList
{
    public class GetRecentCustomerDtoListResponse : DataResult<IEnumerable<CustomerDto>>
    {
    }
}
