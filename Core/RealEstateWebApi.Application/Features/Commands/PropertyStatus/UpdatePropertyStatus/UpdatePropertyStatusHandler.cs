using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.PropertyStatus.UpdatePropertyStatus
{
    public class UpdatePropertyStatusHandler : IRequestHandler<UpdatePropertyStatusRequest, UpdatePropertyStatusResponse>
    {
        private readonly IPropertyStatusReadRepository _propertyStatusReadRepository;
        private readonly IPropertyStatusWriteRepository _propertyStatusWriteRepository;
        public UpdatePropertyStatusHandler(IPropertyStatusReadRepository propertyStatusReadRepository, IPropertyStatusWriteRepository propertyStatusWriteRepository)
        {
            _propertyStatusReadRepository = propertyStatusReadRepository;
            _propertyStatusWriteRepository = propertyStatusWriteRepository;
        }

        public async Task<UpdatePropertyStatusResponse> Handle(UpdatePropertyStatusRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.PropertyStatus propertyStatus = await _propertyStatusReadRepository.GetByIdAsync(request.Id);
            if(propertyStatus is null)
                return new UpdatePropertyStatusResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            propertyStatus.Title = String.IsNullOrEmpty(request.Title) ? propertyStatus.Title : request.Title;
            propertyStatus.IsActive = request.IsActive;
            var result = await _propertyStatusWriteRepository.SaveAsync();
            if(result<0)
                return new UpdatePropertyStatusResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new UpdatePropertyStatusResponse()
            {
                Message = "Kayıt güncellendi.",
                Success = true
            };
        }
    }
}
