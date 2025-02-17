using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.PropertyCategory.UpdatePropertyCategory
{
    public class UpdatePropertyCategoryHandler : IRequestHandler<UpdatePropertyCategoryRequest, UpdatePropertyCategoryResponse>
    {
        private readonly IPropertyCategoryReadRepository _propertyCategoryReadRepository;
        private readonly IPropertyCategoryWriteRepository _propertyCategoryWriteRepository;
        public UpdatePropertyCategoryHandler(IPropertyCategoryReadRepository propertyCategoryReadRepository, IPropertyCategoryWriteRepository propertyCategoryWriteRepository)
        {
            _propertyCategoryReadRepository = propertyCategoryReadRepository;
            _propertyCategoryWriteRepository = propertyCategoryWriteRepository;
        }

        public async Task<UpdatePropertyCategoryResponse> Handle(UpdatePropertyCategoryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.PropertyCategory propertyCategory = await _propertyCategoryReadRepository.GetByIdAsync(request.Id);
            if(propertyCategory is null)
                return new UpdatePropertyCategoryResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            propertyCategory.Title = String.IsNullOrEmpty(request.Title) ? propertyCategory.Title : request.Title;
            propertyCategory.IsActive = request.IsActive;
            var result = await _propertyCategoryWriteRepository.SaveAsync();
            if(result<0)
                return new UpdatePropertyCategoryResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new UpdatePropertyCategoryResponse()
            {
                Message = "Kayıt güncellendi.",
                Success = true
            };
        }
    }
}
