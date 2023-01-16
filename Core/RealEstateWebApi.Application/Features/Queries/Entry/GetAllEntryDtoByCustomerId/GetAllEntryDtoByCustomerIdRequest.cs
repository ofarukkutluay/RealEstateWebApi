using MediatR;


namespace RealEstateWebApi.Application.Features.Queries.Entry.GetAllEntryDtoByCustomerId
{
    public class GetAllEntryDtoByCustomerIdRequest : IRequest<GetAllEntryDtoByCustomerIdResponse>
    {
        public uint CustomerId { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}
