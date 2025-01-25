using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.EntrySubType.UpdateEntrySubType
{
    public class UpdateEntrySubTypeRequest : IRequest<UpdateEntrySubTypeResponse>
    {
        public uint Id { get; set; }
        public uint EntryTypeId { get; set; }
        public string Title { get; set; } 
        public bool IsActive { get; set; }
    }
}
