using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.InternetType.UpdateInternetType
{
    public class UpdateInternetTypeHandler : IRequestHandler<UpdateInternetTypeRequest, UpdateInternetTypeResponse>
    {
        private readonly IInternetTypeReadRepository _internetTypeReadRepository;
        private readonly IInternetTypeWriteRepository _internetTypeWriteRepository;
        public UpdateInternetTypeHandler(IInternetTypeReadRepository internetTypeReadRepository, IInternetTypeWriteRepository internetTypeWriteRepository)
        {
            _internetTypeReadRepository = internetTypeReadRepository;
            _internetTypeWriteRepository = internetTypeWriteRepository;
        }

        public async Task<UpdateInternetTypeResponse> Handle(UpdateInternetTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.InternetType internetType = await _internetTypeReadRepository.GetByIdAsync(request.Id);
            if(internetType is null)
                return new UpdateInternetTypeResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            internetType.Title = String.IsNullOrEmpty(request.Title) ? internetType.Title : request.Title;
            internetType.IsActive = request.IsActive;
            var result = await _internetTypeWriteRepository.SaveAsync();
            if(result<0)
                return new UpdateInternetTypeResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new UpdateInternetTypeResponse()
            {
                Message = "Kayıt güncellendi.",
                Success = true
            };
        }
    }
}
