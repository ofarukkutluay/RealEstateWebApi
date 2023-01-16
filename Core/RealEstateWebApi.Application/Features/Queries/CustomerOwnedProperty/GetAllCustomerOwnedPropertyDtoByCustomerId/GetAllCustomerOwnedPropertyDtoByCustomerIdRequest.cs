using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.CustomerOwnedProperty.GetAllCustomerOwnedPropertyDtoByCustomerId
{
    public class GetAllCustomerOwnedPropertyDtoByCustomerIdRequest : IRequest<GetAllCustomerOwnedPropertyDtoByCustomerIdResponse>
    {
        public uint CustomerId { get; set; }
    }
}
