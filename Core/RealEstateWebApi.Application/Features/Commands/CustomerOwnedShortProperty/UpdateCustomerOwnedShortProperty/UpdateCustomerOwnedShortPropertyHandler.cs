using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerOwnedShortProperty.UpdateCustomerOwnedShortProperty
{
    public class UpdateCustomerOwnedShortPropertyHandler : IRequestHandler<UpdateCustomerOwnedShortPropertyRequest, UpdateCustomerOwnedShortPropertyResponse>
    {
        private readonly ICustomerOwnedShortPropertyReadRepository _customerOwnedShortPropertyReadRepository;
        private readonly ICustomerOwnedShortPropertyWriteRepository _customerOwnedShortPropertyWriteRepository;

        public UpdateCustomerOwnedShortPropertyHandler(ICustomerOwnedShortPropertyWriteRepository customerOwnedShortPropertyWriteRepository, ICustomerOwnedShortPropertyReadRepository customerOwnedShortPropertyReadRepository)
        {
            _customerOwnedShortPropertyWriteRepository = customerOwnedShortPropertyWriteRepository;
            _customerOwnedShortPropertyReadRepository = customerOwnedShortPropertyReadRepository;
        }

        public async Task<UpdateCustomerOwnedShortPropertyResponse> Handle(UpdateCustomerOwnedShortPropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.CustomerOwnedShortProperty customerOwnedShortProperty = await _customerOwnedShortPropertyReadRepository.GetByIdAsync(request.Id);
            if(customerOwnedShortProperty == null)
                return new UpdateCustomerOwnedShortPropertyResponse() { Message="Data bulunamadı",Success=false };

            customerOwnedShortProperty.PropertyId = request.PropertyId;
            customerOwnedShortProperty.IsActive = request.IsActive;
            var result = await _customerOwnedShortPropertyWriteRepository.SaveAsync();
            if(result<0)
                return new UpdateCustomerOwnedShortPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success =false
                };

            return new UpdateCustomerOwnedShortPropertyResponse()
            {
                Message = "Data güncellendi",
                Success = true
            };
        }
    }
}
