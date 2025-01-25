using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.HeatingType.UpdateHeatingType
{
    public class UpdateHeatingTypeRequest : IRequest<UpdateHeatingTypeResponse>
    {
        public uint Id { get; set; }
        public string Title { get; set; } 
        public bool IsActive { get; set; }
    }
}
