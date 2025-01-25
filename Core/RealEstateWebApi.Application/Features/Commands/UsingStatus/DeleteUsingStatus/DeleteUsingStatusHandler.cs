using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.UsingStatus.DeleteUsingStatus
{
    public class DeleteUsingStatusHandler : IRequestHandler<DeleteUsingStatusRequest, DeleteUsingStatusResponse>
    {
        private readonly IUsingStatusReadRepository _usingStatusReadRepository;
        private readonly IUsingStatusWriteRepository _usingStatusWriteRepository;

        public DeleteUsingStatusHandler(IUsingStatusReadRepository usingStatusReadRepository, IUsingStatusWriteRepository usingStatusWriteRepository)
        {
            _usingStatusReadRepository = usingStatusReadRepository;
            _usingStatusWriteRepository = usingStatusWriteRepository;
        }

        public async Task<DeleteUsingStatusResponse> Handle(DeleteUsingStatusRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.UsingStatus usingStatus = await _usingStatusReadRepository.GetByIdAsync(request.Id);
            if(usingStatus == null)
                return new DeleteUsingStatusResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            usingStatus.IsDeleted = true;
            var result = await _usingStatusWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteUsingStatusResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new DeleteUsingStatusResponse()
            {
                Message = "Data silindi",
                Success = true
            };
        }
    }
}
