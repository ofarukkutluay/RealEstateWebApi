using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.ShortProperty.CreateShortProperty
{
    public class CreateShortPropertyHandler : IRequestHandler<CreateShortPropertyRequest, CreateShortPropertyResponse>
    {
        private readonly IShortPropertyWriteRepository _shortPropertyWriteRepository;
        private readonly IMapper _mapper;
        public CreateShortPropertyHandler(IShortPropertyWriteRepository shortPropertyWriteRepository, IMapper mapper)
        {
            _shortPropertyWriteRepository = shortPropertyWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateShortPropertyResponse> Handle(CreateShortPropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.ShortProperty shortProperty = _mapper.Map<Domain.Entities.ShortProperty>(request);
            var result = await _shortPropertyWriteRepository.AddAndSaveAsync(shortProperty);
            if(result is null)
                return new CreateShortPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };

            return new CreateShortPropertyResponse()
            {
                Message = $"{result.Id} id ile kayıt edildi",
                Success = true
            };
        }
    }
}
