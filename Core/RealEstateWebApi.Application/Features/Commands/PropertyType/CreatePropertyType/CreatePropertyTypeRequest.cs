using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.PropertyType.CreatePropertyType
{
    public class CreatePropertyTypeRequest : IRequest<CreatePropertyTypeResponse>
    {
        public string Title { get; set; } 
        public uint PropertyStatusId { get; set; }

    }
}
