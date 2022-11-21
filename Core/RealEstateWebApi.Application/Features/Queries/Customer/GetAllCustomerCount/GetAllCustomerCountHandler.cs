using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomerCount
{
    public class GetAllCustomerCountHandler : IRequestHandler<GetAllcustomerCountRequest, GetAllCustomerCountResponse>
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        public GetAllCustomerCountHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public Task<GetAllCustomerCountResponse> Handle(GetAllcustomerCountRequest request, CancellationToken cancellationToken)
        {
            int count = _customerReadRepository.GetWhere(x => x.IsDeleted == false && x.IsActive == true).Count();
            return Task.FromResult(new GetAllCustomerCountResponse()
            {
                Data = count,
                Message = $"{count} adet müşteri datası bulunmaktadır",
                Success = true
            });
        
        }
    }
}
