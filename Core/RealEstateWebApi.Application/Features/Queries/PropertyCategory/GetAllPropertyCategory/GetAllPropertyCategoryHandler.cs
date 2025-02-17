using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.PropertyCategory.GetAllPropertyCategory
{
    public class GetAllPropertyCategoryHandler : IRequestHandler<GetAllPropertyCategoryRequest, GetAllPropertyCategoryResponse>
    {
        private readonly IPropertyCategoryReadRepository _propertyCategoryReadRepository;

        public GetAllPropertyCategoryHandler(IPropertyCategoryReadRepository propertyCategoryReadRepository)
        {
            _propertyCategoryReadRepository = propertyCategoryReadRepository;
        }

        public async Task<GetAllPropertyCategoryResponse> Handle(GetAllPropertyCategoryRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.PropertyCategory> propertyCategoryes = _propertyCategoryReadRepository.GetAll(false);
            return await Task.FromResult(new GetAllPropertyCategoryResponse()
            {
                Message = $"{propertyCategoryes.Count()} adet data getirildi",
                Success = true,
                Data = propertyCategoryes
            });
        }
    }
}
