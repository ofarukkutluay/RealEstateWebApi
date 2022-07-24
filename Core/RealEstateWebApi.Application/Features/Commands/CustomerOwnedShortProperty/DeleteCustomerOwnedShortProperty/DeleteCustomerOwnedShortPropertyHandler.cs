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

        public DeleteCustomerOwnedShortPropertyHandler(ICustomerOwnedShortPropertyWriteRepository customerOwnedShortPropertyWriteRepository)
        {
            _customerOwnedShortPropertyWriteRepository = customerOwnedShortPropertyWriteRepository;
        }

        public async Task<DeleteCustomerOwnedShortPropertyResponse> Handle(DeleteCustomerOwnedShortPropertyRequest request, CancellationToken cancellationToken)
        {
            await _customerOwnedShortPropertyWriteRepository.RemoveAsync(request.Id);
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
