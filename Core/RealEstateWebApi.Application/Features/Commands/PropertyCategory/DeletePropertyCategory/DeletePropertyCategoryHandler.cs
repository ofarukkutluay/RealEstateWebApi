using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.PropertyCategory.DeletePropertyCategory
{
    public class DeletePropertyCategoryHandler : IRequestHandler<DeletePropertyCategoryRequest, DeletePropertyCategoryResponse>
    {
        private readonly IPropertyCategoryReadRepository _propertyCategoryReadRepository;
        private readonly IPropertyCategoryWriteRepository _propertyCategoryWriteRepository;

        public DeletePropertyCategoryHandler(IPropertyCategoryReadRepository propertyCategoryReadRepository, IPropertyCategoryWriteRepository propertyCategoryWriteRepository)
        {
            _propertyCategoryReadRepository = propertyCategoryReadRepository;
            _propertyCategoryWriteRepository = propertyCategoryWriteRepository;
        }

        public async Task<DeletePropertyCategoryResponse> Handle(DeletePropertyCategoryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.PropertyCategory propertyCategory = await _propertyCategoryReadRepository.GetByIdAsync(request.Id);
            if(propertyCategory == null)
                return new DeletePropertyCategoryResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            propertyCategory.IsDeleted = true;
            var result = await _propertyCategoryWriteRepository.SaveAsync();
            if(result<0)
                return new DeletePropertyCategoryResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new DeletePropertyCategoryResponse()
            {
                Message = "Data silindi",
                Success = true
            };
        }
    }
}
