using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerOwnedProperty.CreateCustomerOwnedProperty
{
    public class CreateCustomerOwnedPropertyHandler : IRequestHandler<CreateCustomerOwnedPropertyRequest, CreateCustomerOwnedPropertyResponse>
    {
        private readonly ICustomerOwnedPropertyReadRepository _customerOwnedShortPropertyReadRepository;
        private readonly ICustomerOwnedPropertyWriteRepository _customerOwnedShortPropertyWriteRepository;
        
        private readonly IMapper _mapper;
        public CreateCustomerOwnedPropertyHandler(ICustomerOwnedPropertyReadRepository customerOwnedShortPropertyReadRepository, ICustomerOwnedPropertyWriteRepository customerOwnedShortPropertyWriteRepository, IMapper mapper)
        {
            _customerOwnedShortPropertyReadRepository = customerOwnedShortPropertyReadRepository;
            _customerOwnedShortPropertyWriteRepository = customerOwnedShortPropertyWriteRepository;
            _mapper = mapper;
        }


        public async Task<CreateCustomerOwnedPropertyResponse> Handle(CreateCustomerOwnedPropertyRequest request, CancellationToken cancellationToken)
        {

            Domain.Entities.CustomerOwnedProperty customerOwnedShortProperty = request.PropertyId == null ? null : await _customerOwnedShortPropertyReadRepository.GetSingleAsync(e=>e.PropertyId == request.PropertyId);
            if(customerOwnedShortProperty != null)
                return new CreateCustomerOwnedPropertyResponse()
                {
                    Message = "Bir ürün, birden fazla yada aynı kişiye iki kere kayıt edilemez",
                    Success = false
                };
            customerOwnedShortProperty = _mapper.Map<Domain.Entities.CustomerOwnedProperty>(request);
            var result = await _customerOwnedShortPropertyWriteRepository.AddAndSaveAsync(customerOwnedShortProperty);
            if(result == null)
                return new CreateCustomerOwnedPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new CreateCustomerOwnedPropertyResponse()
            {
                Message = $"{result.Id} id ile kayıt edildi.",
                Success = true
            };
        }
    }
}
