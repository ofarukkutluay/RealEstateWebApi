using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Entry.CreateEntry
{
    public class CreateEntryHandler : IRequestHandler<CreateEntryRequest, CreateEntryResponse>
    {
        private readonly IEntryWriteRepository _entryWriteRepository;
        private readonly IMapper _mapper;
        public CreateEntryHandler(IEntryWriteRepository entryWriteRepository, IMapper mapper)
        {
            _entryWriteRepository = entryWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateEntryResponse> Handle(CreateEntryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Entry entry = _mapper.Map<Domain.Entities.Entry>(request);
            var result = await _entryWriteRepository.AddAndSaveAsync(entry);
            if (result == null)
                return new CreateEntryResponse()
                {
                    Success = false,
                    Message = "Db ye kayıt edilirken bir hata alındı"
                };

            return new CreateEntryResponse()
            {
                Message = $"{result.Id} id li kayıt edildi",
                Success = true
            };

        }
    }
}
