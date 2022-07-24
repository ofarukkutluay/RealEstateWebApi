using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerOwnedShortProperty.CreateCustomerOwnedShortProperty
{
    public class CreateCustomerOwnedShortPropertyHandler : IRequestHandler<CreateCustomerOwnedShortPropertyRequest, CreateCustomerOwnedShortPropertyResponse>
    {
        private readonly ICustomerOwnedShortPropertyReadRepository _customerOwnedShortPropertyReadRepository;
        private readonly ICustomerOwnedShortPropertyWriteRepository _customerOwnedShortPropertyWriteRepository;
        private readonly IMapper _mapper;
        public CreateCustomerOwnedShortPropertyHandler(ICustomerOwnedShortPropertyReadRepository customerOwnedShortPropertyReadRepository, ICustomerOwnedShortPropertyWriteRepository customerOwnedShortPropertyWriteRepository, IMapper mapper)
        {
            _customerOwnedShortPropertyReadRepository = customerOwnedShortPropertyReadRepository;
            _customerOwnedShortPropertyWriteRepository = customerOwnedShortPropertyWriteRepository;
            _mapper = mapper;
        }


        public async Task<CreateCustomerOwnedShortPropertyResponse> Handle(CreateCustomerOwnedShortPropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.CustomerOwnedShortProperty customerOwnedShortProperty = await _customerOwnedShortPropertyReadRepository.GetSingleAsync(e=>e.ShortPropertyId == request.ShortPropertyId);
            if(customerOwnedShortProperty != null)
                return new CreateCustomerOwnedShortPropertyResponse()
                {
                    Message = "Bir ürün, birden fazla yada aynı kişiye iki kere kayıt edilemez",
                    Success = false
                };
            customerOwnedShortProperty = _mapper.Map<Domain.Entities.CustomerOwnedShortProperty>(customerOwnedShortProperty);
            var result = await _customerOwnedShortPropertyWriteRepository.AddAndSaveAsync(customerOwnedShortProperty);
            if(result == null)
                return new CreateCustomerOwnedShortPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new CreateCustomerOwnedShortPropertyResponse()
            {
                Message = $"{result.Id} id ile kayıt edildi.",
                Success = true
            };
        }
    }
}
