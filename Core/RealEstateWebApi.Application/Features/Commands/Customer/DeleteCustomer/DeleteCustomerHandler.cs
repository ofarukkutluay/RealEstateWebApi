using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Customer.DeleteCustomer
{
    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerRequest, DeleteCustomerResponse>
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;

        public DeleteCustomerHandler(ICustomerWriteRepository customerWriteRepository, ICustomerReadRepository customerReadRepository)
        {
            _customerWriteRepository = customerWriteRepository;
            _customerReadRepository = customerReadRepository;
        }

        public async Task<DeleteCustomerResponse> Handle(DeleteCustomerRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Customer customer = await _customerReadRepository.GetByIdAsync(request.Id);
            if (customer is null)
                return new DeleteCustomerResponse()
                {
                    Message = "Müşteri bulunamadı",
                    Success = false
                };
            await _customerWriteRepository.RemoveAsync(request.Id);
            var result = await _customerWriteRepository.SaveAsync();
            if (result < 0)
                return new DeleteCustomerResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new DeleteCustomerResponse()
            {
                Message = "Müşteri Silindi",
                Success = true
            };
        }
    }
}
