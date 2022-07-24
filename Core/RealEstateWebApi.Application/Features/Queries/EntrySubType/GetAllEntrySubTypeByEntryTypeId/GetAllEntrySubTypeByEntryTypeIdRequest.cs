using MediatR;


namespace RealEstateWebApi.Application.Features.Queries.EntrySubType.GetAllEntrySubTypeByEntryTypeId
{
    public class GetAllEntrySubTypeByEntryTypeIdRequest : IRequest<GetAllEntrySubTypeByEntryTypeIdResponse>
    {
        public uint EntryTypeId { get; set; }
    }
}
