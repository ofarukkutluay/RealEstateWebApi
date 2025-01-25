using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.UsingStatus.UpdateUsingStatus
{
    public class UpdateUsingStatusHandler : IRequestHandler<UpdateUsingStatusRequest, UpdateUsingStatusResponse>
    {
        private readonly IUsingStatusReadRepository _usingStatusReadRepository;
        private readonly IUsingStatusWriteRepository _usingStatusWriteRepository;
        public UpdateUsingStatusHandler(IUsingStatusReadRepository usingStatusReadRepository, IUsingStatusWriteRepository usingStatusWriteRepository)
        {
            _usingStatusReadRepository = usingStatusReadRepository;
            _usingStatusWriteRepository = usingStatusWriteRepository;
        }

        public async Task<UpdateUsingStatusResponse> Handle(UpdateUsingStatusRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.UsingStatus usingStatus = await _usingStatusReadRepository.GetByIdAsync(request.Id);
            if(usingStatus is null)
                return new UpdateUsingStatusResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            usingStatus.Title = String.IsNullOrEmpty(request.Title) ? usingStatus.Title : request.Title;
            usingStatus.IsActive = request.IsActive;
            var result = await _usingStatusWriteRepository.SaveAsync();
            if(result<0)
                return new UpdateUsingStatusResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new UpdateUsingStatusResponse()
            {
                Message = "Kayıt güncellendi.",
                Success = true
            };
        }
    }
}
