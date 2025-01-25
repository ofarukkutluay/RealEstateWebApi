using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Entry.DeleteEntry
{
    public class DeleteEntryHandler : IRequestHandler<DeleteEntryRequest, DeleteEntryResponse>
    {
        private readonly IEntryWriteRepository _entryWriteRepository;
        private readonly IEntryReadRepository _entryReadRepository;

        public DeleteEntryHandler(IEntryWriteRepository entryWriteRepository, IEntryReadRepository entryReadRepository)
        {
            _entryWriteRepository = entryWriteRepository;
            _entryReadRepository = entryReadRepository;
        }

        public async Task<DeleteEntryResponse> Handle(DeleteEntryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Entry entry = await _entryReadRepository.GetByIdAsync(request.Id);
            if (entry == null)
                return new DeleteEntryResponse()
                {
                    Message = "Data bulunamadı",
                    Success = false
                };

            entry.IsDeleted = true;
            var result = await _entryWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteEntryResponse()
                {
                    Message = "Db yekayıtedilirken bir hata oluştu",
                    Success = false
                };
            return new DeleteEntryResponse()
            {
                Message = "Data silindi",
                Success = true
            };
        }
    }
}
