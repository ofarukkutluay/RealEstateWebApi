using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.EntryType.CreateEntryType
{
    public class CreateEntryTypeHandler : IRequestHandler<CreateEntryTypeRequest, CreateEntryTypeResponse>
    {
        private readonly IEntryTypeWriteRepository _entryTypeWriteRepository;
        private readonly IMapper _mapper;
        public CreateEntryTypeHandler(IEntryTypeWriteRepository entryTypeWriteRepository, IMapper mapper)
        {
            _entryTypeWriteRepository = entryTypeWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateEntryTypeResponse> Handle(CreateEntryTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.EntryType entryType = _mapper.Map<Domain.Entities.EntryType>(request);
            var result = await _entryTypeWriteRepository.AddAndSaveAsync(entryType);
            if(result is null)
                return new CreateEntryTypeResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new CreateEntryTypeResponse()
            {
                Message = $"{result.Id} id ile kayıt sağlandı",
                Success = true
            };

        }
    }
}
