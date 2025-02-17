using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerOwnedProperty.UpdateCustomerOwnedProperty
{
    public class UpdateCustomerOwnedPropertyHandler : IRequestHandler<UpdateCustomerOwnedPropertyRequest, UpdateCustomerOwnedPropertyResponse>
    {
        private readonly ICustomerOwnedPropertyReadRepository _customerOwnedShortPropertyReadRepository;
        private readonly ICustomerOwnedPropertyWriteRepository _customerOwnedShortPropertyWriteRepository;

        public UpdateCustomerOwnedPropertyHandler(ICustomerOwnedPropertyWriteRepository customerOwnedShortPropertyWriteRepository, ICustomerOwnedPropertyReadRepository customerOwnedShortPropertyReadRepository)
        {
            _customerOwnedShortPropertyWriteRepository = customerOwnedShortPropertyWriteRepository;
            _customerOwnedShortPropertyReadRepository = customerOwnedShortPropertyReadRepository;
        }

        public async Task<UpdateCustomerOwnedPropertyResponse> Handle(UpdateCustomerOwnedPropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.CustomerOwnedProperty customerOwnedShortProperty = await _customerOwnedShortPropertyReadRepository.GetByIdAsync(request.Id);
            if(customerOwnedShortProperty == null)
                return new UpdateCustomerOwnedPropertyResponse() { Message="Data bulunamadı",Success=false };

            customerOwnedShortProperty.PropertyId = request.PropertyId;
            customerOwnedShortProperty.PropertyCategoryId = request.PropertyCategoryId;
            customerOwnedShortProperty.IsActive = request.IsActive;
            var result = await _customerOwnedShortPropertyWriteRepository.SaveAsync();
            if(result<0)
                return new UpdateCustomerOwnedPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success =false
                };

            return new UpdateCustomerOwnedPropertyResponse()
            {
                Message = "Data güncellendi",
                Success = true
            };
        }
    }
}
