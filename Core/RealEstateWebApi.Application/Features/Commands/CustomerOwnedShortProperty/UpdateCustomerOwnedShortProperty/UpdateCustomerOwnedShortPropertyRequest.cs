using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerOwnedShortProperty.UpdateCustomerOwnedShortProperty
{
    public class UpdateCustomerOwnedShortPropertyRequest : IRequest<UpdateCustomerOwnedShortPropertyResponse>
    {
        public uint Id { get; set; }
        public uint? PropertyId { get; set; }
        public bool IsActive { get; set; }
    }
}
