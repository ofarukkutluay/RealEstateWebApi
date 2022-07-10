using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.InternetType.CreateInternetType
{
    public class CreateInternetTypeRequest : IRequest<CreateInternetTypeResponse>
    {
        public string Title { get; set; } 
    }
}
