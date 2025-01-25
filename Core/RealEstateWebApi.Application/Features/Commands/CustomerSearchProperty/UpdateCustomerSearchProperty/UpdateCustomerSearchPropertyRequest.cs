using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerSearchProperty.UpdateCustomerSearchProperty
{
    public class UpdateCustomerSearchPropertyRequest : IRequest<UpdateCustomerSearchPropertyResponse>
    {
        public uint Id { get; set; }
        public bool IsActive { get; set; }
    }
}
