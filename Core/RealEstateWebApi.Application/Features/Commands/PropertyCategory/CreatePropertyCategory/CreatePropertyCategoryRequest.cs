using MediatR;


namespace RealEstateWebApi.Application.Features.Commands.PropertyCategory.CreatePropertyCategory
{
    public class CreatePropertyCategoryRequest : IRequest<CreatePropertyCategoryResponse>
    {
        public string Title { get; set; } 
    }
}
