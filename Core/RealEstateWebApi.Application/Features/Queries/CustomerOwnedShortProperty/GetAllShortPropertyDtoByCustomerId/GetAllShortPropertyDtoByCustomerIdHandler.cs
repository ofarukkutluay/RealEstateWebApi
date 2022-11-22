using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.CustomerOwnedShortProperty.GetAllShortPropertyDtoByCustomerId
{
    public class GetAllShortPropertyDtoByCustomerIdHandler : IRequestHandler<GetAllShortPropertyDtoByCustomerIdRequest, GetAllShortPropertyDtoByCustomerIdResponse>
    {
        private readonly ICustomerOwnedShortPropertyReadRepository _customerOwnedShortPropertyReadRepository;

        public GetAllShortPropertyDtoByCustomerIdHandler(ICustomerOwnedShortPropertyReadRepository customerOwnedShortPropertyReadRepository)
        {
            _customerOwnedShortPropertyReadRepository = customerOwnedShortPropertyReadRepository;
        }

        public Task<GetAllShortPropertyDtoByCustomerIdResponse> Handle(GetAllShortPropertyDtoByCustomerIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<CustomerOwnedShortPropertyDto> shortPropertyDtos = _customerOwnedShortPropertyReadRepository.GetAllShortPropertyDtoByCustomerId(request.CustomerId);
            return Task.FromResult(new GetAllShortPropertyDtoByCustomerIdResponse()
            {
                Data = shortPropertyDtos,
                Success = true,
                Message = $"{shortPropertyDtos.Count()} adet data getirildi"
            });
        }
    }
}
