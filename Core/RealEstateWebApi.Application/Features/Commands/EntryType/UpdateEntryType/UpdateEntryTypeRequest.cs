using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.EntryType.UpdateEntryType
{
    public class UpdateEntryTypeRequest : IRequest<UpdateEntryTypeResponse>
    {
        public uint Id { get; set; }
        public string Title { get; set; } 
        public bool IsActive { get; set; }
    }
}
