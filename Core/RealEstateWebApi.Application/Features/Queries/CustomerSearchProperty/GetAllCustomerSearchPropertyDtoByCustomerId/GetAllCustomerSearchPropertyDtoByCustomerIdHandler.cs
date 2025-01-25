using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.CustomerSearchProperty.GetAllCustomerSearchPropertyDtoByCustomerId
{
    public class GetAllCustomerSearchPropertyDtoByCustomerIdHandler : IRequestHandler<GetAllCustomerSearchPropertyDtoByCustomerIdRequest, GetAllCustomerSearchPropertyDtoByCustomerIdResponse>
    {
        private readonly ICustomerSearchPropertyReadRepository _customerSearchPropertyReadRepository;

        public GetAllCustomerSearchPropertyDtoByCustomerIdHandler(ICustomerSearchPropertyReadRepository customerSearchPropertyReadRepository)
        {
            _customerSearchPropertyReadRepository = customerSearchPropertyReadRepository;
        }

        public Task<GetAllCustomerSearchPropertyDtoByCustomerIdResponse> Handle(GetAllCustomerSearchPropertyDtoByCustomerIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<CustomerSearchPropertyDto> propertyDtos = _customerSearchPropertyReadRepository.GetAllCustomerSearchPropertyDtoByCustomerId(request.CustomerId);
            return Task.FromResult(new GetAllCustomerSearchPropertyDtoByCustomerIdResponse()
            {
                Data = propertyDtos,
                Success = true,
                Message = $"{propertyDtos.Count()} adet data getirildi"
            });
        }
    }
}
