using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.CustomerOwnedShortProperty.GetAllCustomerOwnedShortPropertyByCustomerId
{
    public class GetAllCustomerOwnedShortPropertyByCustomerIdRequest : IRequest<GetAllCustomerOwnedShortPropertyByCustomerIdResponse>
    {
        public uint CustomerId { get; set; }
    }
}
