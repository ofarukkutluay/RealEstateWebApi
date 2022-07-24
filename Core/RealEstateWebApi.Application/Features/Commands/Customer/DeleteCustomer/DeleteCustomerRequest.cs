using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Customer.DeleteCustomer
{
    public class DeleteCustomerRequest : IRequest<DeleteCustomerResponse>
    {
        public uint Id { get; set; }
    }
}
