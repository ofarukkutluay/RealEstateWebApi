using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.EntrySubType.DeleteEntrySubType
{
    public class DeleteEntrySubTypeHandler : IRequestHandler<DeleteEntrySubTypeRequest, DeleteEntrySubTypeResponse>
    {
        private readonly IEntrySubTypeReadRepository _entrySubTypeReadRepository;
        private readonly IEntrySubTypeWriteRepository _entrySubTypeWriteRepository;

        public DeleteEntrySubTypeHandler(IEntrySubTypeReadRepository entrySubTypeReadRepository, IEntrySubTypeWriteRepository entrySubTypeWriteRepository)
        {
            _entrySubTypeReadRepository = entrySubTypeReadRepository;
            _entrySubTypeWriteRepository = entrySubTypeWriteRepository;
        }

        public async Task<DeleteEntrySubTypeResponse> Handle(DeleteEntrySubTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.EntrySubType EntrySubType = await _entrySubTypeReadRepository.GetByIdAsync(request.Id);
            if(EntrySubType == null)
                return new DeleteEntrySubTypeResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            await _entrySubTypeWriteRepository.RemoveAsync(request.Id);
            var result = await _entrySubTypeWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteEntrySubTypeResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new DeleteEntrySubTypeResponse()
            {
                Message = "Data silindi",
                Success = true
            };
        }
    }
}
