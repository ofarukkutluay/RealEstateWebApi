using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerSearchProperty.DeleteCustomerSearchProperty
{
    public class DeleteCustomerSearchPropertyRequest : IRequest<DeleteCustomerSearchPropertyResponse>
    {
        public uint Id { get; set; }
    }
}
