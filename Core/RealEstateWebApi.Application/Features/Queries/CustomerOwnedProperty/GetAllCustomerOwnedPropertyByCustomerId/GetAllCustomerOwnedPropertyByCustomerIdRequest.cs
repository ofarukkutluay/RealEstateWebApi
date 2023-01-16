using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.CustomerOwnedProperty.GetAllCustomerOwnedPropertyByCustomerId
{
    public class GetAllCustomerOwnedPropertyByCustomerIdRequest : IRequest<GetAllCustomerOwnedPropertyByCustomerIdResponse>
    {
        public uint CustomerId { get; set; }
    }
}
