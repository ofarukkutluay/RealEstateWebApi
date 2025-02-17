using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.PropertyType.UpdatePropertyType
{
    public class UpdatePropertyTypeRequest : IRequest<UpdatePropertyTypeResponse>
    {
        public uint Id { get; set; }
        public string Title { get; set; } 
        public uint PropertyStatusId { get; set; }
        public bool IsActive { get; set; }
    }
}
