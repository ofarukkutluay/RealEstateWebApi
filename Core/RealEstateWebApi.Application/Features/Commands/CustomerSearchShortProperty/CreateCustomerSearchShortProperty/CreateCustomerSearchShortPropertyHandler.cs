using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerSearchShortProperty.CreateCustomerSearchShortProperty
{
    public class CreateCustomerSearchShortPropertyHandler : IRequestHandler<CreateCustomerSearchShortPropertyRequest, CreateCustomerSearchShortPropertyResponse>
    {
        private readonly ICustomerSearchShortPropertyReadRepository _customerSearchShortPropertyReadRepository;
        private readonly ICustomerSearchShortPropertyWriteRepository _customerSearchShortPropertyWriteRepository;
        private readonly IMapper _mapper;
        public CreateCustomerSearchShortPropertyHandler(ICustomerSearchShortPropertyReadRepository customerSearchShortPropertyReadRepository, ICustomerSearchShortPropertyWriteRepository customerSearchShortPropertyWriteRepository, IMapper mapper)
        {
            _customerSearchShortPropertyReadRepository = customerSearchShortPropertyReadRepository;
            _customerSearchShortPropertyWriteRepository = customerSearchShortPropertyWriteRepository;
            _mapper = mapper;
        }


        public async Task<CreateCustomerSearchShortPropertyResponse> Handle(CreateCustomerSearchShortPropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.CustomerSearchShortProperty customerSearchShortProperty = await _customerSearchShortPropertyReadRepository.GetSingleAsync(e=>e.ShortPropertyId == request.ShortPropertyId);
            if(customerSearchShortProperty != null)
                return new CreateCustomerSearchShortPropertyResponse()
                {
                    Message = "Bir ürün, birden fazla yada aynı kişiye iki kere kayıt edilemez",
                    Success = false
                };
            customerSearchShortProperty = _mapper.Map<Domain.Entities.CustomerSearchShortProperty>(customerSearchShortProperty);
            var result = await _customerSearchShortPropertyWriteRepository.AddAndSaveAsync(customerSearchShortProperty);
            if(result == null)
                return new CreateCustomerSearchShortPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new CreateCustomerSearchShortPropertyResponse()
            {
                Message = $"{result.Id} id ile kayıt edildi.",
                Success = true
            };
        }
    }
}
