using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.Front.UpdateFront
{
    public class UpdateFrontRequest : IRequest<UpdateFrontResponse>
    {
        public uint Id { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
    }
}
