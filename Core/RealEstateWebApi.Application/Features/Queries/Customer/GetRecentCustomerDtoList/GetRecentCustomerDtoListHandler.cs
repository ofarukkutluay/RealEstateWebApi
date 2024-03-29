﻿using MediatR;
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
            DateTime firstdate = DateTime.FromBinary(request.FirstDate).Date;
            IQueryable<CustomerDto> customers = _customerReadRepository.GetAllDto()
                .Where(x => x.CreatedDate.Date >= firstdate)
                .OrderByDescending(x => x.CreatedDate);

            if (request.UserId != null && request.UserId > 0)
            {
                customers = _customerReadRepository.GetAllDtoByAssignedUserId((uint)request.UserId)
                    .Where(x => x.CreatedDate.Date >= firstdate)
                    .OrderByDescending(x => x.CreatedDate);
            }
            return Task.FromResult(new GetRecentCustomerDtoListResponse()
            {
                Data = customers.AsEnumerable(),
                Success = true,
                Message = $"{customers.Count()} adet data getirildi"
            });
        }
    }
}
