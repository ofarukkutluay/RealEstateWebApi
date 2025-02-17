using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.PropertyType.UpdatePropertyType
{
    public class UpdatePropertyTypeHandler : IRequestHandler<UpdatePropertyTypeRequest, UpdatePropertyTypeResponse>
    {
        private readonly IPropertyTypeReadRepository _propertyTypeReadRepository;
        private readonly IPropertyTypeWriteRepository _propertyTypeWriteRepository;
        public UpdatePropertyTypeHandler(IPropertyTypeReadRepository propertyTypeReadRepository, IPropertyTypeWriteRepository propertyTypeWriteRepository)
        {
            _propertyTypeReadRepository = propertyTypeReadRepository;
            _propertyTypeWriteRepository = propertyTypeWriteRepository;
        }

        public async Task<UpdatePropertyTypeResponse> Handle(UpdatePropertyTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.PropertyType propertyType = await _propertyTypeReadRepository.GetByIdAsync(request.Id);
            if(propertyType is null)
                return new UpdatePropertyTypeResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            propertyType.Title = String.IsNullOrEmpty(request.Title) ? propertyType.Title : request.Title;
            propertyType.PropertyStatusId = request.PropertyStatusId;
            propertyType.IsActive = request.IsActive;
            var result = await _propertyTypeWriteRepository.SaveAsync();
            if(result<0)
                return new UpdatePropertyTypeResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new UpdatePropertyTypeResponse()
            {
                Message = "Kayıt güncellendi.",
                Success = true
            };
        }
    }
}
