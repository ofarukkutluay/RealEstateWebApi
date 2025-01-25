using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Customer.ChangeActivateCustomer
{
    public class ChangeActivateCustomerHandler : IRequestHandler<ChangeActivateCustomerRequest, ChangeActivateCustomerResponse>
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;

        public ChangeActivateCustomerHandler(ICustomerWriteRepository customerWriteRepository, ICustomerReadRepository customerReadRepository)
        {
            _customerWriteRepository = customerWriteRepository;
            _customerReadRepository = customerReadRepository;
        }

        public async Task<ChangeActivateCustomerResponse> Handle(ChangeActivateCustomerRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Customer customer = await _customerReadRepository.GetByIdAsync(request.CustomerId);
            if (customer is null)
            {
                return new ChangeActivateCustomerResponse()
                {
                    Message = "Müşteri buunamadı",
                    Success = false
                };

            }

            customer.IsActive = request.Activate;
            var result = await _customerWriteRepository.SaveAsync();
            if (result < 0)
            {
                return new ChangeActivateCustomerResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };
            }

            return new ChangeActivateCustomerResponse()
            {
                Message = "Güncelleme sağlandı",
                Success = true
            };
        }
    }
}
