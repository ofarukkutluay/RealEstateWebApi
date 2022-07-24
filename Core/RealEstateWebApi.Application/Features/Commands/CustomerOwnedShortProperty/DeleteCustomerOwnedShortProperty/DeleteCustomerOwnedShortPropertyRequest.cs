using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerOwnedShortProperty.DeleteCustomerOwnedShortProperty
{
    public class DeleteCustomerOwnedShortPropertyRequest : IRequest<DeleteCustomerOwnedShortPropertyResponse>
    {
        public uint Id { get; set; }
    }
}
