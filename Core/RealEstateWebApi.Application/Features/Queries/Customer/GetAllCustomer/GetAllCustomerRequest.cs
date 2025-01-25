using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateWebApi.Domain.Entities.HelperEntities;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomer
{
    public class GetAllCustomerRequest : Pagination, IRequest<GetAllCustomerResponse>
    {
        
    }
}
