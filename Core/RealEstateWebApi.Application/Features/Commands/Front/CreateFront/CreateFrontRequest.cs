using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.Front.CreateFront
{
    public class CreateFrontRequest : IRequest<CreateFrontResponse>
    {
        public string Title { get; set; }
    }
}
