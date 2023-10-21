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
            IEnumerable<CustomerOwnedPropertyDto> sizedPropertyDtos = _customerOwnedPropertyReadRepository.GetAllCustomerOwnedPropertyDto(new Domain.Entities.HelperEntities.Pagination() { PageIndex = request.PageIndex,PageSize = request.PageSize});
            int totalCount = _customerOwnedPropertyReadRepository.Table.Count();
            return Task.FromResult(new GetAllCustomerOwnedPropertyDtoResponse()
            {
                Data = sizedPropertyDtos,
                TotalDataCount = totalCount,
                Success = true,
                Message = $"{sizedPropertyDtos.Count()} adet data getirildi"
            });
        }
    }
}
