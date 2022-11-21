using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.CustomerOwnedShortProperty.DeleteCustomerOwnedShortProperty
{
    public class DeleteCustomerOwnedShortPropertyHandler : IRequestHandler<DeleteCustomerOwnedShortPropertyRequest, DeleteCustomerOwnedShortPropertyResponse>
    {
        private readonly ICustomerOwnedShortPropertyWriteRepository _customerOwnedShortPropertyWriteRepository;
        private readonly ICustomerOwnedShortPropertyReadRepository _customerOwnedShortPropertyReadRepository;

        public DeleteCustomerOwnedShortPropertyHandler(ICustomerOwnedShortPropertyWriteRepository customerOwnedShortPropertyWriteRepository, ICustomerOwnedShortPropertyReadRepository customerOwnedShortPropertyReadRepository)
        {
            _customerOwnedShortPropertyWriteRepository = customerOwnedShortPropertyWriteRepository;
            _customerOwnedShortPropertyReadRepository = customerOwnedShortPropertyReadRepository;
        }

        public async Task<DeleteCustomerOwnedShortPropertyResponse> Handle(DeleteCustomerOwnedShortPropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.CustomerOwnedShortProperty customerOwnedShortProperty = await _customerOwnedShortPropertyReadRepository.GetByIdAsync(request.Id);
            if (customerOwnedShortProperty is null)
                return new DeleteCustomerOwnedShortPropertyResponse()
                {
                    Message = "Data bulunamadı",
                    Success = false,
                };
            customerOwnedShortProperty.IsDeleted = true;
            var result =await _customerOwnedShortPropertyWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteCustomerOwnedShortPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new DeleteCustomerOwnedShortPropertyResponse()
            {
                Message = "Data silindi",
                Success = true
            };


        }
    }
}
