using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetRecentCustomerDtoList
{
    public class GetRecentCustomerDtoListHandler : IRequestHandler<GetRecentCustomerDtoListRequest, GetRecentCustomerDtoListResponse>
    {
        private readonly ICustomerReadRepository _customerReadRepository;

        public GetRecentCustomerDtoListHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public Task<GetRecentCustomerDtoListResponse> Handle(GetRecentCustomerDtoListRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<CustomerDto> customers = _customerReadRepository.GetAllDto().OrderByDescending(x=>x.CreatedDate).Take(request.Take);
            return Task.FromResult(new GetRecentCustomerDtoListResponse()
            {
                Data = customers,
                Success = true,
                Message = $"{customers.Count()} adet data getirildi"
            });
        }
    }
}
