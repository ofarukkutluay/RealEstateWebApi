using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.CustomerSearchShortProperty.GetAllShortPropertyDtoByCustomerId
{
    public class GetAllShortPropertyDtoByCustomerIdHandler : IRequestHandler<GetAllShortPropertyDtoByCustomerIdRequest, GetAllShortPropertyDtoByCustomerIdResponse>
    {
        private readonly ICustomerSearchShortPropertyReadRepository _customerSearchShortPropertyReadRepository;

        public GetAllShortPropertyDtoByCustomerIdHandler(ICustomerSearchShortPropertyReadRepository customerSearchShortPropertyReadRepository)
        {
            _customerSearchShortPropertyReadRepository = customerSearchShortPropertyReadRepository;
        }

        public Task<GetAllShortPropertyDtoByCustomerIdResponse> Handle(GetAllShortPropertyDtoByCustomerIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<ShortPropertyDto> shortPropertyDtos = _customerSearchShortPropertyReadRepository.GetAllShortPropertyDtoByCustomerId(request.CustomerId);
            return Task.FromResult(new GetAllShortPropertyDtoByCustomerIdResponse()
            {
                Data = shortPropertyDtos,
                Success = true,
                Message = $"{shortPropertyDtos.Count()} adet data getirildi"
            });
        }
    }
}
