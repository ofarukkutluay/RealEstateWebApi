﻿using MediatR;
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
            IEnumerable<Domain.Entities.Customer> customers = _customerReadRepository.GetWhere(x => x.IsDeleted == false);
            return await Task.FromResult(new GetAllCustomerResponse()
            {
                Message = $"{customers.Count()} adet data getirildi",
                Success = true,
                Data = customers
            });
            
        }
    }
}
