using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.InternetType.UpdateInternetType
{
    public class UpdateInternetTypeRequest : IRequest<UpdateInternetTypeResponse>
    {
        public uint Id { get; set; }
        public string Title { get; set; } 
        public bool IsActive { get; set; }
    }
}
