using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.CustomerSearchProperty.CreateCustomerSearchProperty
{
    public class CreateCustomerSearchPropertyHandler : IRequestHandler<CreateCustomerSearchPropertyRequest, CreateCustomerSearchPropertyResponse>
    {
        private readonly ICustomerSearchPropertyWriteRepository _customerSearchPropertyWriteRepository;
        private readonly IMapper _mapper;
        public CreateCustomerSearchPropertyHandler(ICustomerSearchPropertyWriteRepository customerSearchPropertyWriteRepository, IMapper mapper)
        {
            _customerSearchPropertyWriteRepository = customerSearchPropertyWriteRepository;
            _mapper = mapper;
        }


        public async Task<CreateCustomerSearchPropertyResponse> Handle(CreateCustomerSearchPropertyRequest request, CancellationToken cancellationToken)
        {


            Domain.Entities.CustomerSearchProperty customerSearchShortProperty = _mapper.Map<Domain.Entities.CustomerSearchProperty>(request);
            var result = await _customerSearchPropertyWriteRepository.AddAndSaveAsync(customerSearchShortProperty);
            if(result == null)
                return new CreateCustomerSearchPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new CreateCustomerSearchPropertyResponse()
            {
                Message = $"{result.Id} id ile kayıt edildi.",
                Success = true
            };
        }
    }
}
