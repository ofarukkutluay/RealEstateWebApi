﻿using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.EntryType.DeleteEntryType
{
    public class DeleteEntryTypeHandler : IRequestHandler<DeleteEntryTypeRequest, DeleteEntryTypeResponse>
    {
        private readonly IEntryTypeReadRepository _entryTypeReadRepository;
        private readonly IEntryTypeWriteRepository _entryTypeWriteRepository;

        public DeleteEntryTypeHandler(IEntryTypeReadRepository entryTypeReadRepository, IEntryTypeWriteRepository entryTypeWriteRepository)
        {
            _entryTypeReadRepository = entryTypeReadRepository;
            _entryTypeWriteRepository = entryTypeWriteRepository;
        }

        public async Task<DeleteEntryTypeResponse> Handle(DeleteEntryTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.EntryType entryType = await _entryTypeReadRepository.GetByIdAsync(request.Id);
            if(entryType == null)
                return new DeleteEntryTypeResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            entryType.IsDeleted = true;
            var result = await _entryTypeWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteEntryTypeResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new DeleteEntryTypeResponse()
            {
                Message = "Data silindi",
                Success = true
            };
        }
    }
}
