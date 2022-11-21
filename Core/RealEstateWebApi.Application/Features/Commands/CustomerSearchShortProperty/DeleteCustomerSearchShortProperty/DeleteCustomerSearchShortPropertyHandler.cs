using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerSearchShortProperty.DeleteCustomerSearchShortProperty
{
    public class DeleteCustomerSearchShortPropertyHandler : IRequestHandler<DeleteCustomerSearchShortPropertyRequest, DeleteCustomerSearchShortPropertyResponse>
    {
        private readonly ICustomerSearchShortPropertyWriteRepository _customerSearchShortPropertyWriteRepository;
        private readonly ICustomerSearchShortPropertyReadRepository _customerSearchShortPropertyReadRepository;

        public DeleteCustomerSearchShortPropertyHandler(ICustomerSearchShortPropertyWriteRepository customerSearchShortPropertyWriteRepository, ICustomerSearchShortPropertyReadRepository customerSearchShortPropertyReadRepository)
        {
            _customerSearchShortPropertyWriteRepository = customerSearchShortPropertyWriteRepository;
            _customerSearchShortPropertyReadRepository = customerSearchShortPropertyReadRepository;
        }

        public async Task<DeleteCustomerSearchShortPropertyResponse> Handle(DeleteCustomerSearchShortPropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.CustomerSearchShortProperty customerSearchShortProperty = await _customerSearchShortPropertyReadRepository.GetByIdAsync(request.Id);
            if (customerSearchShortProperty == null)
                return new DeleteCustomerSearchShortPropertyResponse()
                {
                    Message = "Data bulunamadı",
                    Success = false
                };

            customerSearchShortProperty.IsDeleted = true;
            var result =await _customerSearchShortPropertyWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteCustomerSearchShortPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new DeleteCustomerSearchShortPropertyResponse()
            {
                Message = "Data silindi",
                Success = true
            };


        }
    }
}
