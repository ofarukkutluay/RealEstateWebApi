using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetCustomerById
{
    public class GetCustomerByIdRequest : IRequest<GetCustomerByIdResponse>
    {
        public uint Id { get; set; }
    }
}
