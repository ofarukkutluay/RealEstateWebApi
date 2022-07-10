using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.HeatingType.CreateHeatingType
{
    public class CreateHeatingTypeRequest : IRequest<CreateHeatingTypeResponse>
    {
        public string Title { get; set; } 
    }
}
