using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerSearchProperty.DeleteCustomerSearchProperty
{
    public class DeleteCustomerSearchPropertyHandler : IRequestHandler<DeleteCustomerSearchPropertyRequest, DeleteCustomerSearchPropertyResponse>
    {
        private readonly ICustomerSearchPropertyWriteRepository _customerSearchShortPropertyWriteRepository;
        private readonly ICustomerSearchPropertyReadRepository _customerSearchShortPropertyReadRepository;

        public DeleteCustomerSearchPropertyHandler(ICustomerSearchPropertyWriteRepository customerSearchShortPropertyWriteRepository, ICustomerSearchPropertyReadRepository customerSearchShortPropertyReadRepository)
        {
            _customerSearchShortPropertyWriteRepository = customerSearchShortPropertyWriteRepository;
            _customerSearchShortPropertyReadRepository = customerSearchShortPropertyReadRepository;
        }

        public async Task<DeleteCustomerSearchPropertyResponse> Handle(DeleteCustomerSearchPropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.CustomerSearchProperty customerSearchShortProperty = await _customerSearchShortPropertyReadRepository.GetByIdAsync(request.Id);
            if (customerSearchShortProperty == null)
                return new DeleteCustomerSearchPropertyResponse()
                {
                    Message = "Data bulunamadı",
                    Success = false
                };

            customerSearchShortProperty.IsDeleted = true;
            var result =await _customerSearchShortPropertyWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteCustomerSearchPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new DeleteCustomerSearchPropertyResponse()
            {
                Message = "Data silindi",
                Success = true
            };


        }
    }
}
