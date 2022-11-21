using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Features.Commands.ShortProperty.CreateShortProperty;
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
        private readonly IShortPropertyWriteRepository _shortPropertyWriteRepository;
        private readonly IMapper _mapper;
        public CreateCustomerOwnedShortPropertyHandler(ICustomerOwnedShortPropertyReadRepository customerOwnedShortPropertyReadRepository, ICustomerOwnedShortPropertyWriteRepository customerOwnedShortPropertyWriteRepository, IMapper mapper, IShortPropertyWriteRepository shortPropertyWriteRepository)
        {
            _customerOwnedShortPropertyReadRepository = customerOwnedShortPropertyReadRepository;
            _customerOwnedShortPropertyWriteRepository = customerOwnedShortPropertyWriteRepository;
            _mapper = mapper;
            _shortPropertyWriteRepository = shortPropertyWriteRepository;
        }


        public async Task<CreateCustomerOwnedShortPropertyResponse> Handle(CreateCustomerOwnedShortPropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.ShortProperty shortProperty = _mapper.Map<Domain.Entities.ShortProperty>(request);
            var shortPropertyResult = await _shortPropertyWriteRepository.AddAndSaveAsync(shortProperty);
            if (shortPropertyResult is null)
                return new CreateCustomerOwnedShortPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };

            request.ShortPropertyId = shortPropertyResult.Id;

            Domain.Entities.CustomerOwnedShortProperty customerOwnedShortProperty = await _customerOwnedShortPropertyReadRepository.GetSingleAsync(e=>e.ShortPropertyId == request.ShortPropertyId);
            if(customerOwnedShortProperty != null)
                return new CreateCustomerOwnedShortPropertyResponse()
                {
                    Message = "Bir ürün, birden fazla yada aynı kişiye iki kere kayıt edilemez",
                    Success = false
                };
            customerOwnedShortProperty = new Domain.Entities.CustomerOwnedShortProperty()
            {
                CustomerId = request.CustomerId,
                ShortPropertyId = request.ShortPropertyId,
                PropertyId = request.PropertyId,
                ShLink = request.ShLink,
                HeLink = request.HeLink,
                EjLink = request.EjLink,
                OtherLink = request.OtherLink
            };
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
