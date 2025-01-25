using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.DeedStatus.UpdateDeedStatus
{
    public class UpdateDeedStatusHandler : IRequestHandler<UpdateDeedStatusRequest, UpdateDeedStatusResponse>
    {
        private readonly IDeedStatusReadRepository _deedStatusReadRepository;
        private readonly IDeedStatusWriteRepository _deedStatusWriteRepository;
        public UpdateDeedStatusHandler(IDeedStatusReadRepository deedStatusReadRepository, IDeedStatusWriteRepository deedStatusWriteRepository)
        {
            _deedStatusReadRepository = deedStatusReadRepository;
            _deedStatusWriteRepository = deedStatusWriteRepository;
        }

        public async Task<UpdateDeedStatusResponse> Handle(UpdateDeedStatusRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.DeedStatus deedStatus = await _deedStatusReadRepository.GetByIdAsync(request.Id);
            if(deedStatus is null)
                return new UpdateDeedStatusResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            deedStatus.Title = String.IsNullOrEmpty(request.Title) ? deedStatus.Title : request.Title;
            deedStatus.IsActive = request.IsActive;
            var result = await _deedStatusWriteRepository.SaveAsync();
            if(result<0)
                return new UpdateDeedStatusResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new UpdateDeedStatusResponse()
            {
                Message = "Kayıt güncellendi.",
                Success = true
            };
        }
    }
}
