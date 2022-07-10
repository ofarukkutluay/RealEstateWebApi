using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.HeatingType.DeleteHeatingType
{
    public class DeleteHeatingTypeHandler : IRequestHandler<DeleteHeatingTypeRequest, DeleteHeatingTypeResponse>
    {
        private readonly IHeatingTypeReadRepository _heatingTypeReadRepository;
        private readonly IHeatingTypeWriteRepository _heatingTypeWriteRepository;

        public DeleteHeatingTypeHandler(IHeatingTypeReadRepository heatingTypeReadRepository, IHeatingTypeWriteRepository heatingTypeWriteRepository)
        {
            _heatingTypeReadRepository = heatingTypeReadRepository;
            _heatingTypeWriteRepository = heatingTypeWriteRepository;
        }

        public async Task<DeleteHeatingTypeResponse> Handle(DeleteHeatingTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.HeatingType heatingType = await _heatingTypeReadRepository.GetByIdAsync(request.Id);
            if(heatingType == null)
                return new DeleteHeatingTypeResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            await _heatingTypeWriteRepository.RemoveAsync(request.Id);
            var result = await _heatingTypeWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteHeatingTypeResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new DeleteHeatingTypeResponse()
            {
                Message = "Data silindi",
                Success = true
            };
        }
    }
}
