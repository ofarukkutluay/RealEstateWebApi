using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.PropertyStatus.UpdatePropertyStatus
{
    public class UpdatePropertyStatusRequest : IRequest<UpdatePropertyStatusResponse>
    {
        public uint Id { get; set; }
        public string Title { get; set; } 
        public uint PropertyCategoryId { get; set; }
        public bool IsActive { get; set; }
    }
}
