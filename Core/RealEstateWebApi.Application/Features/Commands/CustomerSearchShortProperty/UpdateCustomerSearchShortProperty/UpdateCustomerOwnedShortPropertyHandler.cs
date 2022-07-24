using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerSearchShortProperty.UpdateCustomerSearchShortProperty
{
    public class UpdateCustomerSearchShortPropertyHandler : IRequestHandler<UpdateCustomerSearchShortPropertyRequest, UpdateCustomerSearchShortPropertyResponse>
    {
        private readonly ICustomerSearchShortPropertyReadRepository _customerSearchShortPropertyReadRepository;
        private readonly ICustomerSearchShortPropertyWriteRepository _customerSearchShortPropertyWriteRepository;

        public UpdateCustomerSearchShortPropertyHandler(ICustomerSearchShortPropertyWriteRepository customerSearchShortPropertyWriteRepository, ICustomerSearchShortPropertyReadRepository customerSearchShortPropertyReadRepository)
        {
            _customerSearchShortPropertyWriteRepository = customerSearchShortPropertyWriteRepository;
            _customerSearchShortPropertyReadRepository = customerSearchShortPropertyReadRepository;
        }

        public async Task<UpdateCustomerSearchShortPropertyResponse> Handle(UpdateCustomerSearchShortPropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.CustomerSearchShortProperty customerSearchShortProperty = await _customerSearchShortPropertyReadRepository.GetByIdAsync(request.Id);
            if(customerSearchShortProperty == null)
                return new UpdateCustomerSearchShortPropertyResponse() { Message="Data bulunamadı",Success=false };

            customerSearchShortProperty.IsActive = request.IsActive;
            var result = await _customerSearchShortPropertyWriteRepository.SaveAsync();
            if(result<0)
                return new UpdateCustomerSearchShortPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success =false
                };

            return new UpdateCustomerSearchShortPropertyResponse()
            {
                Message = "Data güncellendi",
                Success = true
            };
        }
    }
}
