using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerOwnedShortProperty.CreateCustomerOwnedShortProperty
{
    public class CreateCustomerOwnedShortPropertyRequest : IRequest<CreateCustomerOwnedShortPropertyResponse>
    {
        public uint CustomerId { get; set; }
        public uint ShortPropertyId { get; set; }
        public uint? PropertyId { get; set; }
    }
}
