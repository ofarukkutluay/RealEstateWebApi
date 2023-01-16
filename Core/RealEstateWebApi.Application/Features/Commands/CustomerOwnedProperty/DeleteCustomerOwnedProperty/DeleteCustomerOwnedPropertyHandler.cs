using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerOwnedProperty.DeleteCustomerOwnedProperty
{
    public class DeleteCustomerOwnedPropertyHandler : IRequestHandler<DeleteCustomerOwnedPropertyRequest, DeleteCustomerOwnedPropertyResponse>
    {
        private readonly ICustomerOwnedPropertyWriteRepository _customerOwnedShortPropertyWriteRepository;
        private readonly ICustomerOwnedPropertyReadRepository _customerOwnedShortPropertyReadRepository;

        public DeleteCustomerOwnedPropertyHandler(ICustomerOwnedPropertyWriteRepository customerOwnedShortPropertyWriteRepository, ICustomerOwnedPropertyReadRepository customerOwnedShortPropertyReadRepository)
        {
            _customerOwnedShortPropertyWriteRepository = customerOwnedShortPropertyWriteRepository;
            _customerOwnedShortPropertyReadRepository = customerOwnedShortPropertyReadRepository;
        }

        public async Task<DeleteCustomerOwnedPropertyResponse> Handle(DeleteCustomerOwnedPropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.CustomerOwnedProperty customerOwnedShortProperty = await _customerOwnedShortPropertyReadRepository.GetByIdAsync(request.Id);
            if (customerOwnedShortProperty is null)
                return new DeleteCustomerOwnedPropertyResponse()
                {
                    Message = "Data bulunamadı",
                    Success = false,
                };
            customerOwnedShortProperty.IsDeleted = true;
            var result =await _customerOwnedShortPropertyWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteCustomerOwnedPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new DeleteCustomerOwnedPropertyResponse()
            {
                Message = "Data silindi",
                Success = true
            };


        }
    }
}
