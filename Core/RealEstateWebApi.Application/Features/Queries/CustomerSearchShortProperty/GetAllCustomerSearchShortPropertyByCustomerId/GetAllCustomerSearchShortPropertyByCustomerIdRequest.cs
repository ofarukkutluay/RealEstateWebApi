using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.CustomerSearchShortProperty.GetAllCustomerSearchShortPropertyByCustomerId
{
    public class GetAllCustomerSearchShortPropertyByCustomerIdRequest : IRequest<GetAllCustomerSearchShortPropertyByCustomerIdResponse>
    {
        public uint CustomerId { get; set; }
    }
}
