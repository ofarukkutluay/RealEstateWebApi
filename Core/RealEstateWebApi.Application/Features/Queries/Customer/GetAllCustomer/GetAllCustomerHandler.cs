using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomer
{
    public class GetAllCustomerHandler : IRequestHandler<GetAllCustomerRequest, GetAllCustomerResponse>
    {
        private readonly ICustomerReadRepository _customerReadRepository;

        public GetAllCustomerHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public async Task<GetAllCustomerResponse> Handle(GetAllCustomerRequest request, CancellationToken cancellationToken)
        {
            IQueryable<Domain.Entities.Customer> customers = _customerReadRepository.GetAll(false);
            IEnumerable<Domain.Entities.Customer> sizedCustomers =
                customers.Skip(request.PageIndex * request.PageSize).Take(request.PageSize);
            return await Task.FromResult(new GetAllCustomerResponse()
            {
                Message = $"{sizedCustomers.Count()} adet data getirildi",
                Success = true,
                Data = sizedCustomers,
                TotalDataCount = customers.Count()
            });
            
        }
    }
}
