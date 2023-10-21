using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.CustomerOwnedProperty.GetAllCustomerOwnedPropertyDto
{
    public class GetAllCustomerOwnedPropertyDtoHandler : IRequestHandler<GetAllCustomerOwnedPropertyDtoRequest, GetAllCustomerOwnedPropertyDtoResponse>
    {
        private readonly ICustomerOwnedPropertyReadRepository _customerOwnedPropertyReadRepository;

        public GetAllCustomerOwnedPropertyDtoHandler(ICustomerOwnedPropertyReadRepository customerOwnedPropertyReadRepository)
        {
            _customerOwnedPropertyReadRepository = customerOwnedPropertyReadRepository;
        }

        public Task<GetAllCustomerOwnedPropertyDtoResponse> Handle(GetAllCustomerOwnedPropertyDtoRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<CustomerOwnedPropertyDto> propertyDtos = _customerOwnedPropertyReadRepository.GetAllCustomerOwnedPropertyDto();
            IEnumerable<CustomerOwnedPropertyDto> sizedPropertyDtos = propertyDtos.Skip(request.PageIndex * request.PageSize).Take(request.PageSize);
            return Task.FromResult(new GetAllCustomerOwnedPropertyDtoResponse()
            {
                Data = sizedPropertyDtos,
                TotalDataCount = propertyDtos.Count(),
                Success = true,
                Message = $"{sizedPropertyDtos.Count()} adet data getirildi"
            });
        }
    }
}
