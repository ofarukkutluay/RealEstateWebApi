using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.EntryType.UpdateEntryType
{
    public class UpdateEntryTypeHandler : IRequestHandler<UpdateEntryTypeRequest, UpdateEntryTypeResponse>
    {
        private readonly IEntryTypeReadRepository _entryTypeReadRepository;
        private readonly IEntryTypeWriteRepository _entryTypeWriteRepository;
        public UpdateEntryTypeHandler(IEntryTypeReadRepository entryTypeReadRepository, IEntryTypeWriteRepository entryTypeWriteRepository)
        {
            _entryTypeReadRepository = entryTypeReadRepository;
            _entryTypeWriteRepository = entryTypeWriteRepository;
        }

        public async Task<UpdateEntryTypeResponse> Handle(UpdateEntryTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.EntryType entryType = await _entryTypeReadRepository.GetByIdAsync(request.Id);
            if(entryType is null)
                return new UpdateEntryTypeResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            entryType.Title = String.IsNullOrEmpty(request.Title) ? entryType.Title : request.Title;
            entryType.IsActive = request.IsActive;
            var result = await _entryTypeWriteRepository.SaveAsync();
            if(result<0)
                return new UpdateEntryTypeResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new UpdateEntryTypeResponse()
            {
                Message = "Kayıt güncellendi.",
                Success = true
            };
        }
    }
}
