using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Client.DeleteClient
{
    public class DeleteClientHandler : IRequestHandler<DeleteClientRequest, DeleteClientResponse>
    {
        private readonly IClientReadRepository _clientReadRepository;
        private readonly IClientWriteRepository _clientWriteRepository;

        public DeleteClientHandler(IClientReadRepository clientReadRepository, IClientWriteRepository clientWriteRepository)
        {
            _clientReadRepository = clientReadRepository;
            _clientWriteRepository = clientWriteRepository;
        }

        public async Task<DeleteClientResponse> Handle(DeleteClientRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Client client = await _clientReadRepository.GetByIdAsync(request.Id);
            if(client == null)
                return new DeleteClientResponse()
                {
                    Message = "Client bulunamadı",
                    Success = false
                };
            var result = await _clientWriteRepository.RemoveAsync(request.Id);
            if(!result)
                return new DeleteClientResponse()
                {
                    Message = "Db ye işlem yapılırken bir hata alındı.",
                    Success = false
                };
            return new DeleteClientResponse()
            {
                Message = "Data silindi",
                Success = true
            };
        }
    }
}
