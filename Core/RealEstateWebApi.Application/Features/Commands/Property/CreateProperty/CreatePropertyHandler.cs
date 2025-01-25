using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Property.CreateProperty
{
    public class CreatePropertyHandler : IRequestHandler<CreatePropertyRequest, CreatePropertyResponse>
    {
        private readonly IPropertyReadRepository _propertyReadRepository;
        private readonly IPropertyWriteRepository _propertyWriteRepository;
        private readonly IMapper _mapper;
        public CreatePropertyHandler(IPropertyReadRepository propertyReadRepository, IPropertyWriteRepository propertyWriteRepository, IMapper mapper)
        {
            _propertyReadRepository = propertyReadRepository;
            _propertyWriteRepository = propertyWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreatePropertyResponse> Handle(CreatePropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Property property = await _propertyReadRepository.GetSingleAsync(e=>e.Title.ToLower() == request.Title.ToLower() && e.IsDeleted==false);
            if(property != null)
                return new CreatePropertyResponse()
                {
                    Message = "İlettiğiniz title da property bulunmaktadır. Tekrar kayıt edilemez",
                    Success = false
                };

            property = _mapper.Map<Domain.Entities.Property>(request);
            var result = await _propertyWriteRepository.AddAndSaveAsync(property);
            if(result == null)
                return new CreatePropertyResponse()
                {
                    Message = "Dbye kayıt edilirken bir hata oluştu",
                    Success = false
                };

            return new CreatePropertyResponse()
            {
                Message = $"{result.Id} id ile kayıt edildi.",
                Success = true
            };
        }
    }
}
