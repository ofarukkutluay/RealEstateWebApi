using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.PropertyStatus.DeletePropertyStatus
{
    public class DeletePropertyStatusHandler : IRequestHandler<DeletePropertyStatusRequest, DeletePropertyStatusResponse>
    {
        private readonly IPropertyStatusReadRepository _propertyStatusReadRepository;
        private readonly IPropertyStatusWriteRepository _propertyStatusWriteRepository;

        public DeletePropertyStatusHandler(IPropertyStatusReadRepository propertyStatusReadRepository, IPropertyStatusWriteRepository propertyStatusWriteRepository)
        {
            _propertyStatusReadRepository = propertyStatusReadRepository;
            _propertyStatusWriteRepository = propertyStatusWriteRepository;
        }

        public async Task<DeletePropertyStatusResponse> Handle(DeletePropertyStatusRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.PropertyStatus propertyStatus = await _propertyStatusReadRepository.GetByIdAsync(request.Id);
            if(propertyStatus == null)
                return new DeletePropertyStatusResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            await _propertyStatusWriteRepository.RemoveAsync(request.Id);
            var result = await _propertyStatusWriteRepository.SaveAsync();
            if(result<0)
                return new DeletePropertyStatusResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new DeletePropertyStatusResponse()
            {
                Message = "Data silindi",
                Success = true
            };
        }
    }
}
