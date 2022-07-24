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

        public DeleteEntryHandler(IEntryWriteRepository entryWriteRepository)
        {
            _entryWriteRepository = entryWriteRepository;
        }

        public async Task<DeleteEntryResponse> Handle(DeleteEntryRequest request, CancellationToken cancellationToken)
        {
            await _entryWriteRepository.RemoveAsync(request.Id);
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
