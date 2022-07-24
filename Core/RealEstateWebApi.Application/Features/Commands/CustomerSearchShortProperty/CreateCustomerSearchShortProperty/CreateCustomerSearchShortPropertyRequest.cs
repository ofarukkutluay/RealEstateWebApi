using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerSearchShortProperty.CreateCustomerSearchShortProperty
{
    public class CreateCustomerSearchShortPropertyRequest : IRequest<CreateCustomerSearchShortPropertyResponse>
    {
        public uint CustomerId { get; set; }
        public uint ShortPropertyId { get; set; }
    }
}
