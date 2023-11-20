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
            IQueryable<CustomerOwnedPropertyDto> ownedPropertyDtos = _customerOwnedPropertyReadRepository.GetAllCustomerOwnedPropertyDto();
            IEnumerable<CustomerOwnedPropertyDto> sizedOwnedPropertyDtos = ownedPropertyDtos.Skip(request.PageIndex * request.PageSize).Take(request.PageSize);
            return Task.FromResult(new GetAllCustomerOwnedPropertyDtoResponse()
            {
                Data = sizedOwnedPropertyDtos,
                TotalDataCount = ownedPropertyDtos.Count(),
                Success = true,
                Message = $"{sizedOwnedPropertyDtos.Count()} adet data getirildi"
            });
        }
    }
}
