using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.PropertyCategory.UpdatePropertyCategory
{
    public class UpdatePropertyCategoryRequest : IRequest<UpdatePropertyCategoryResponse>
    {
        public uint Id { get; set; }
        public string Title { get; set; } 
        public bool IsActive { get; set; }
    }
}
