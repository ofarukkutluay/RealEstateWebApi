using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetCustomerById
{
    public class GetCustomerByIdHandler : IRequestHandler<GetCustomerByIdRequest, GetCustomerByIdResponse>
    {
        private readonly ICustomerReadRepository _customerReadRepository;

        public GetCustomerByIdHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public async Task<GetCustomerByIdResponse> Handle(GetCustomerByIdRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Customer customer = await _customerReadRepository.GetByIdAsync(request.Id);
            if(customer.IsDeleted)
                return new GetCustomerByIdResponse()
                {
                    Message = "Data silinmiş",
                    Success = false
                };
            return new GetCustomerByIdResponse()
            {
                Data = customer,
                Success = true
            };
        }
    }
}
