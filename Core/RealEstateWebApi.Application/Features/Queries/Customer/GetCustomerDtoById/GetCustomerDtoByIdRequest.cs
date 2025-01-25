using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetCustomerDtoById
{
    public class GetCustomerDtoByIdRequest : IRequest<GetCustomerDtoByIdResponse>
    {
        public uint Id { get; set; }
    }
}
