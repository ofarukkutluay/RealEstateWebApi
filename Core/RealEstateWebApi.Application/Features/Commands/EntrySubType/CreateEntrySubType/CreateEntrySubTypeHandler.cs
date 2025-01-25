using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.EntrySubType.CreateEntrySubType
{
    public class CreateEntrySubTypeHandler : IRequestHandler<CreateEntrySubTypeRequest, CreateEntrySubTypeResponse>
    {
        private readonly IEntrySubTypeWriteRepository _entrySubTypeWriteRepository;
        private readonly IMapper _mapper;
        public CreateEntrySubTypeHandler(IEntrySubTypeWriteRepository entrySubTypeWriteRepository, IMapper mapper)
        {
            _entrySubTypeWriteRepository = entrySubTypeWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateEntrySubTypeResponse> Handle(CreateEntrySubTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.EntrySubType entrySubType = _mapper.Map<Domain.Entities.EntrySubType>(request);
            var result = await _entrySubTypeWriteRepository.AddAndSaveAsync(entrySubType);
            if(result is null)
                return new CreateEntrySubTypeResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new CreateEntrySubTypeResponse()
            {
                Message = $"{result.Id} id ile kayıt sağlandı",
                Success = true
            };

        }
    }
}
