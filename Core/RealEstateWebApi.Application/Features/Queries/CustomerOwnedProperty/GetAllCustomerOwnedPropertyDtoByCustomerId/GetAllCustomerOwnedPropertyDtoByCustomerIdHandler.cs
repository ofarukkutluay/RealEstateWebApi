using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.CustomerOwnedProperty.GetAllCustomerOwnedPropertyDtoByCustomerId
{
    public class GetAllCustomerOwnedPropertyDtoByCustomerIdHandler : IRequestHandler<GetAllCustomerOwnedPropertyDtoByCustomerIdRequest, GetAllCustomerOwnedPropertyDtoByCustomerIdResponse>
    {
        private readonly ICustomerOwnedPropertyReadRepository _customerOwnedPropertyReadRepository;

        public GetAllCustomerOwnedPropertyDtoByCustomerIdHandler(ICustomerOwnedPropertyReadRepository customerOwnedPropertyReadRepository)
        {
            _customerOwnedPropertyReadRepository = customerOwnedPropertyReadRepository;
        }

        public Task<GetAllCustomerOwnedPropertyDtoByCustomerIdResponse> Handle(GetAllCustomerOwnedPropertyDtoByCustomerIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<CustomerOwnedPropertyDto> propertyDtos = _customerOwnedPropertyReadRepository.GetAllCustomerOwnedPropertyDtoByCustomerId(request.CustomerId);
            return Task.FromResult(new GetAllCustomerOwnedPropertyDtoByCustomerIdResponse()
            {
                Data = propertyDtos,
                Success = true,
                Message = $"{propertyDtos.Count()} adet data getirildi"
            });
        }
    }
}
