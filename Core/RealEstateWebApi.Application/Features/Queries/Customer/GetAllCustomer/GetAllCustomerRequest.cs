using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomer
{
    public class GetAllCustomerRequest : IRequest<GetAllCustomerResponse>
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
