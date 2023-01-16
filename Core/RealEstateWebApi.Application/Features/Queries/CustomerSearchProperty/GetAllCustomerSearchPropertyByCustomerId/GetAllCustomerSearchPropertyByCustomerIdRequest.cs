using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.CustomerSearchProperty.GetAllCustomerSearchPropertyByCustomerId
{
    public class GetAllCustomerSearchPropertyByCustomerIdRequest : IRequest<GetAllCustomerSearchPropertyByCustomerIdResponse>
    {
        public uint CustomerId { get; set; }
    }
}
