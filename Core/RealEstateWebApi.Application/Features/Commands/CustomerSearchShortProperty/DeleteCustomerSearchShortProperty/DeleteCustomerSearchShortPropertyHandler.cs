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

        public DeleteCustomerSearchShortPropertyHandler(ICustomerSearchShortPropertyWriteRepository customerSearchShortPropertyWriteRepository)
        {
            _customerSearchShortPropertyWriteRepository = customerSearchShortPropertyWriteRepository;
        }

        public async Task<DeleteCustomerSearchShortPropertyResponse> Handle(DeleteCustomerSearchShortPropertyRequest request, CancellationToken cancellationToken)
        {
            await _customerSearchShortPropertyWriteRepository.RemoveAsync(request.Id);
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
