using MediatR;
using RealEstateWebApi.Domain.Entities.HelperEntities;

namespace RealEstateWebApi.Application.Features.Queries.Entry.GetAllEntryDtoByCustomerId
{
    public class GetAllEntryDtoByCustomerIdRequest :Pagination, IRequest<GetAllEntryDtoByCustomerIdResponse>
    {
        public uint CustomerId { get; set; }

    }
}
