using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.EntrySubType.UpdateEntrySubType
{
    public class UpdateEntrySubTypeHandler : IRequestHandler<UpdateEntrySubTypeRequest, UpdateEntrySubTypeResponse>
    {
        private readonly IEntrySubTypeReadRepository _entrySubTypeReadRepository;
        private readonly IEntrySubTypeWriteRepository _entrySubTypeWriteRepository;
        public UpdateEntrySubTypeHandler(IEntrySubTypeReadRepository entrySubTypeReadRepository, IEntrySubTypeWriteRepository entrySubTypeWriteRepository)
        {
            _entrySubTypeReadRepository = entrySubTypeReadRepository;
            _entrySubTypeWriteRepository = entrySubTypeWriteRepository;
        }

        public async Task<UpdateEntrySubTypeResponse> Handle(UpdateEntrySubTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.EntrySubType entrySubType = await _entrySubTypeReadRepository.GetByIdAsync(request.Id);
            if(entrySubType is null)
                return new UpdateEntrySubTypeResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            entrySubType.Title = String.IsNullOrEmpty(request.Title) ? entrySubType.Title : request.Title;
            entrySubType.EntryTypeId = request.EntryTypeId == default ? entrySubType.EntryTypeId : request.EntryTypeId;
            entrySubType.IsActive = request.IsActive;
            var result = await _entrySubTypeWriteRepository.SaveAsync();
            if(result<0)
                return new UpdateEntrySubTypeResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new UpdateEntrySubTypeResponse()
            {
                Message = "Kayıt güncellendi.",
                Success = true
            };
        }
    }
}
