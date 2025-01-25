using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.HeatingType.UpdateHeatingType
{
    public class UpdateHeatingTypeHandler : IRequestHandler<UpdateHeatingTypeRequest, UpdateHeatingTypeResponse>
    {
        private readonly IHeatingTypeReadRepository _heatingTypeReadRepository;
        private readonly IHeatingTypeWriteRepository _heatingTypeWriteRepository;
        public UpdateHeatingTypeHandler(IHeatingTypeReadRepository heatingTypeReadRepository, IHeatingTypeWriteRepository heatingTypeWriteRepository)
        {
            _heatingTypeReadRepository = heatingTypeReadRepository;
            _heatingTypeWriteRepository = heatingTypeWriteRepository;
        }

        public async Task<UpdateHeatingTypeResponse> Handle(UpdateHeatingTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.HeatingType heatingType = await _heatingTypeReadRepository.GetByIdAsync(request.Id);
            if(heatingType is null)
                return new UpdateHeatingTypeResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            heatingType.Title = String.IsNullOrEmpty(request.Title) ? heatingType.Title : request.Title;
            heatingType.IsActive = request.IsActive;
            var result = await _heatingTypeWriteRepository.SaveAsync();
            if(result<0)
                return new UpdateHeatingTypeResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new UpdateHeatingTypeResponse()
            {
                Message = "Kayıt güncellendi.",
                Success = true
            };
        }
    }
}
