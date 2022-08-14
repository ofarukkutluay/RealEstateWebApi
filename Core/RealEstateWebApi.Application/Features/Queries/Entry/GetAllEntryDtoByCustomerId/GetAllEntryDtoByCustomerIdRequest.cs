using MediatR;


namespace RealEstateWebApi.Application.Features.Queries.Entry.GetAllEntryDtoByCustomerId
{
    public class GetAllEntryDtoByCustomerIdRequest : IRequest<GetAllEntryDtoByCustomerIdResponse>
    {
        public uint CustomerId { get; set; }
    }
}
