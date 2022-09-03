using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Features.Commands.CustomerOwnedShortProperty.CreateCustomerOwnedShortProperty;
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
        private readonly IShortPropertyWriteRepository _shortPropertyWriteRepository;
        private readonly IMapper _mapper;
        public CreateCustomerSearchShortPropertyHandler(ICustomerSearchShortPropertyReadRepository customerSearchShortPropertyReadRepository, ICustomerSearchShortPropertyWriteRepository customerSearchShortPropertyWriteRepository, IMapper mapper, IShortPropertyWriteRepository shortPropertyWriteRepository)
        {
            _customerSearchShortPropertyReadRepository = customerSearchShortPropertyReadRepository;
            _customerSearchShortPropertyWriteRepository = customerSearchShortPropertyWriteRepository;
            _mapper = mapper;
            _shortPropertyWriteRepository = shortPropertyWriteRepository;
        }


        public async Task<CreateCustomerSearchShortPropertyResponse> Handle(CreateCustomerSearchShortPropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.ShortProperty shortProperty = _mapper.Map<Domain.Entities.ShortProperty>(request);
            var shortPropertyResult = await _shortPropertyWriteRepository.AddAndSaveAsync(shortProperty);
            if (shortPropertyResult is null)
                return new CreateCustomerSearchShortPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };

            request.ShortPropertyId = shortPropertyResult.Id;


            Domain.Entities.CustomerSearchShortProperty customerSearchShortProperty = await _customerSearchShortPropertyReadRepository.GetSingleAsync(e=>e.ShortPropertyId == request.ShortPropertyId);
            if(customerSearchShortProperty != null)
                return new CreateCustomerSearchShortPropertyResponse()
                {
                    Message = "Bir ürün, birden fazla yada aynı kişiye iki kere kayıt edilemez",
                    Success = false
                };
            customerSearchShortProperty = new Domain.Entities.CustomerSearchShortProperty()
            {
                CustomerId = request.CustomerId,
                ShortPropertyId = request.ShortPropertyId
            };
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
