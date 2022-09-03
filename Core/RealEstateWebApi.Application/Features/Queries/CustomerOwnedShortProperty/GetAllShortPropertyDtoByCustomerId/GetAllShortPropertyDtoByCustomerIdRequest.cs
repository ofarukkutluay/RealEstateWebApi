using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.CustomerOwnedShortProperty.GetAllShortPropertyDtoByCustomerId
{
    public class GetAllShortPropertyDtoByCustomerIdRequest : IRequest<GetAllShortPropertyDtoByCustomerIdResponse>
    {
        public uint CustomerId { get; set; }
    }
}
