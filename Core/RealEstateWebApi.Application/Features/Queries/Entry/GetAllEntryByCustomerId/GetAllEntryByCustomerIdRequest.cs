using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Entry.GetAllEntryByCustomerId
{
    public class GetAllEntryByCustomerIdRequest : IRequest<GetAllEntryByCustomerIdResponse>
    {
        public uint CustomerId { get; set; }
    }
}
