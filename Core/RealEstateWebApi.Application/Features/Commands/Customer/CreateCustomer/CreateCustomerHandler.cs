using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Customer.CreateCustomer
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;
        private readonly IMapper _mapper;

        public CreateCustomerHandler(ICustomerWriteRepository customerWriteRepository, ICustomerReadRepository customerReadRepository, IMapper mapper)
        {
            _customerWriteRepository = customerWriteRepository;
            _customerReadRepository = customerReadRepository;
            _mapper = mapper;
        }

        public async Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Customer customer = await _customerReadRepository.GetSingleAsync(e=>e.MobileNumber == request.MobileNumber);
            if(customer is not null)
                return new CreateCustomerResponse(){
                    Message = "Bu numaraya ait data bulunmakatadır.",
                    Success = false
                };
            
            customer = _mapper.Map<Domain.Entities.Customer>(request);
            customer.AssignedUserId = request.RegisterUserId;
            var result = await _customerWriteRepository.AddAndSaveAsync(customer);
            if(result is null)
                return new CreateCustomerResponse(){
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new CreateCustomerResponse(){
                
                Message = $"{result.Id} id ile kayıt gerçekleşti",
                Success = true
                
            };
        }
    }
}
