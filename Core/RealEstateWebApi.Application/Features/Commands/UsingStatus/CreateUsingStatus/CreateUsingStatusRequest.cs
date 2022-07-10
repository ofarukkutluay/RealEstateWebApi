using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.UsingStatus.CreateUsingStatus
{
    public class CreateUsingStatusRequest : IRequest<CreateUsingStatusResponse>
    {
        public string Title { get; set; } 
    }
}
