using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerSearchShortProperty.DeleteCustomerSearchShortProperty
{
    public class DeleteCustomerSearchShortPropertyRequest : IRequest<DeleteCustomerSearchShortPropertyResponse>
    {
        public uint Id { get; set; }
    }
}
