using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.Front.UpdateFront
{
    public class UpdateFrontHandler : IRequestHandler<UpdateFrontRequest, UpdateFrontResponse>
    {
        private readonly IFrontReadRepository _frontReadRepository;
        private readonly IFrontWriteRepository _frontWriteRepository;
        public UpdateFrontHandler(IFrontReadRepository frontReadRepository, IFrontWriteRepository frontWriteRepository)
        {
            _frontReadRepository = frontReadRepository;
            _frontWriteRepository = frontWriteRepository;
        }

        public async Task<UpdateFrontResponse> Handle(UpdateFrontRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Front front = await _frontReadRepository.GetByIdAsync(request.Id);
            if(front is null)
                return new UpdateFrontResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            front.Title = String.IsNullOrEmpty(request.Title) ? front.Title : request.Title;
            front.IsActive = request.IsActive;
            var result = await _frontWriteRepository.SaveAsync();
            if(result<0)
                return new UpdateFrontResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new UpdateFrontResponse()
            {
                Message = "Kayıt güncellendi.",
                Success = true
            };
        }
    }
}
