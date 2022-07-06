using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Client.CreateClient
{
    public class CreateClientHandler : IRequestHandler<CreateClientRequest, CreateClientResponse>
    {
        private readonly IClientReadRepository _clientReadRepository;
        private readonly IClientWriteRepository _clientWriteRepository;
        private readonly IMapper _mapper;

        public CreateClientHandler(IClientWriteRepository clientWriteRepository, IClientReadRepository clientReadRepository, IMapper mapper)
        {
            _clientWriteRepository = clientWriteRepository;
            _clientReadRepository = clientReadRepository;
            _mapper = mapper;
        }

        public async Task<CreateClientResponse> Handle(CreateClientRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Client client = await _clientReadRepository.GetSingleAsync(e => e.Dns == request.Dns);
            if (client is not null)
                return new CreateClientResponse()
                {
                    Message = "Aynı dns adresinde client oluşturulamaz",
                    Success = false
                };
            client = _mapper.Map<Domain.Entities.Client>(request);
            var result = await _clientWriteRepository.AddAndSaveAsync(client);
            if(result is null)
                return new CreateClientResponse()
                {
                    Message = "Db kayıt edilirken bir hata alındı",
                    Success = false
                };
            return new CreateClientResponse()
            {
                Message = $"{result.Id} id ile kayıt edildi",
                Success = true,
            };

        }
    }
}
