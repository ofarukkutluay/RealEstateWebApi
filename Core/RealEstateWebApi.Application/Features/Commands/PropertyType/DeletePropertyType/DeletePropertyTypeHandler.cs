using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.PropertyType.DeletePropertyType
{
    public class DeletePropertyTypeHandler : IRequestHandler<DeletePropertyTypeRequest, DeletePropertyTypeResponse>
    {
        private readonly IPropertyTypeReadRepository _propertyTypeReadRepository;
        private readonly IPropertyTypeWriteRepository _propertyTypeWriteRepository;

        public DeletePropertyTypeHandler(IPropertyTypeReadRepository propertyTypeReadRepository, IPropertyTypeWriteRepository propertyTypeWriteRepository)
        {
            _propertyTypeReadRepository = propertyTypeReadRepository;
            _propertyTypeWriteRepository = propertyTypeWriteRepository;
        }

        public async Task<DeletePropertyTypeResponse> Handle(DeletePropertyTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.PropertyType propertyType = await _propertyTypeReadRepository.GetByIdAsync(request.Id);
            if(propertyType == null)
                return new DeletePropertyTypeResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            propertyType.IsDeleted = true;
            var result = await _propertyTypeWriteRepository.SaveAsync();
            if(result<0)
                return new DeletePropertyTypeResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new DeletePropertyTypeResponse()
            {
                Message = "Data silindi",
                Success = true
            };
        }
    }
}
