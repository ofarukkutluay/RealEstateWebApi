using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.DeedStatus.UpdateDeedStatus
{
    public class UpdateDeedStatusRequest : IRequest<UpdateDeedStatusResponse>
    {
        public uint Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
    }
}
