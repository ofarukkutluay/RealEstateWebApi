using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.InternetType.DeleteInternetType
{
    public class DeleteInternetTypeHandler : IRequestHandler<DeleteInternetTypeRequest, DeleteInternetTypeResponse>
    {
        private readonly IInternetTypeReadRepository _internetTypeReadRepository;
        private readonly IInternetTypeWriteRepository _internetTypeWriteRepository;

        public DeleteInternetTypeHandler(IInternetTypeReadRepository internetTypeReadRepository, IInternetTypeWriteRepository internetTypeWriteRepository)
        {
            _internetTypeReadRepository = internetTypeReadRepository;
            _internetTypeWriteRepository = internetTypeWriteRepository;
        }

        public async Task<DeleteInternetTypeResponse> Handle(DeleteInternetTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.InternetType internetType = await _internetTypeReadRepository.GetByIdAsync(request.Id);
            if(internetType == null)
                return new DeleteInternetTypeResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            await _internetTypeWriteRepository.RemoveAsync(request.Id);
            var result = await _internetTypeWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteInternetTypeResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new DeleteInternetTypeResponse()
            {
                Message = "Data silindi",
                Success = true
            };
        }
    }
}
