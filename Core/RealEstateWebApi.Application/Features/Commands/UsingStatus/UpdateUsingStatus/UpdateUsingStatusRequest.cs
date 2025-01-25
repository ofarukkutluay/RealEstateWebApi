using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.UsingStatus.UpdateUsingStatus
{
    public class UpdateUsingStatusRequest : IRequest<UpdateUsingStatusResponse>
    {
        public uint Id { get; set; }
        public string Title { get; set; } 
        public bool IsActive { get; set; }
    }
}
