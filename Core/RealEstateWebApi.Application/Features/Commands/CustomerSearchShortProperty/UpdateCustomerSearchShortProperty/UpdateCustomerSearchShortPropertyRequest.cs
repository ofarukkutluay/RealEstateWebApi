using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerSearchShortProperty.UpdateCustomerSearchShortProperty
{
    public class UpdateCustomerSearchShortPropertyRequest : IRequest<UpdateCustomerSearchShortPropertyResponse>
    {
        public uint Id { get; set; }
        public bool IsActive { get; set; }
    }
}
