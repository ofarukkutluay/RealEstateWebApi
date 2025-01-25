using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.PropertyStatus.CreatePropertyStatus
{
    public class CreatePropertyStatusRequest : IRequest<CreatePropertyStatusResponse>
    {
        public string Title { get; set; } 
    }
}
