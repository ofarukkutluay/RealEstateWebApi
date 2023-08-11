using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.Property.DeleteProperty
{
    public class DeletePropertyRequest : IRequest<DeletePropertyResponse>
    {
        public uint PropertyId { get; set; }
    }
}
