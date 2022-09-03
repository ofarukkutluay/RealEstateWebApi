using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetRecentCustomerDtoList
{
    public class GetRecentCustomerDtoListRequest : IRequest<GetRecentCustomerDtoListResponse>
    {
        public int Take { get; set; }
    }
}
