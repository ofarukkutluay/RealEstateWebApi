﻿using System;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;

namespace RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomerDtoByStatusKey
{
    public class GetAllCustomerDtoByStatusKeyHandler : IRequestHandler<GetAllCustomerDtoByStatusKeyRequest, GetAllCustomerDtoByStatusKeyResponse>
    {
        private readonly ICustomerReadRepository _customerReadRepository;

        public GetAllCustomerDtoByStatusKeyHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public async Task<GetAllCustomerDtoByStatusKeyResponse> Handle(GetAllCustomerDtoByStatusKeyRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<CustomerDto> customerDtos = _customerReadRepository.GetAllDtoByStatusKey(request.StatusKey, request.AssignedUserId)
                .Skip(request.PageIndex * request.PageSize).Take(request.PageSize);
            return new GetAllCustomerDtoByStatusKeyResponse
            {
                Data = customerDtos,
                Message = $"{customerDtos.Count()} adet data getirildi",
                Success = true
            };
        }
    }
}

