using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerSearchProperty.UpdateCustomerSearchProperty
{
    public class UpdateCustomerSearchPropertyHandler : IRequestHandler<UpdateCustomerSearchPropertyRequest, UpdateCustomerSearchPropertyResponse>
    {
        private readonly ICustomerSearchPropertyReadRepository _customerSearchShortPropertyReadRepository;
        private readonly ICustomerSearchPropertyWriteRepository _customerSearchShortPropertyWriteRepository;

        public UpdateCustomerSearchPropertyHandler(ICustomerSearchPropertyWriteRepository customerSearchShortPropertyWriteRepository, ICustomerSearchPropertyReadRepository customerSearchShortPropertyReadRepository)
        {
            _customerSearchShortPropertyWriteRepository = customerSearchShortPropertyWriteRepository;
            _customerSearchShortPropertyReadRepository = customerSearchShortPropertyReadRepository;
        }

        public async Task<UpdateCustomerSearchPropertyResponse> Handle(UpdateCustomerSearchPropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.CustomerSearchProperty customerSearchShortProperty = await _customerSearchShortPropertyReadRepository.GetByIdAsync(request.Id);
            if(customerSearchShortProperty == null)
                return new UpdateCustomerSearchPropertyResponse() { Message="Data bulunamadı",Success=false };

            customerSearchShortProperty.IsActive = request.IsActive;
            var result = await _customerSearchShortPropertyWriteRepository.SaveAsync();
            if(result<0)
                return new UpdateCustomerSearchPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success =false
                };

            return new UpdateCustomerSearchPropertyResponse()
            {
                Message = "Data güncellendi",
                Success = true
            };
        }
    }
}
