using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.CustomerSearchProperty.GetAllCustomerSearchPropertyDtoByCustomerId
{
    public class GetAllCustomerSearchPropertyDtoByCustomerIdRequest : IRequest<GetAllCustomerSearchPropertyDtoByCustomerIdResponse>
    {
        public uint CustomerId { get; set; }
    }
}
