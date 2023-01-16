using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.CustomerOwnedProperty.GetAllCustomerOwnedPropertyByCustomerId
{
    public class GetAllCustomerOwnedPropertyByCustomerIdHandler : IRequestHandler<GetAllCustomerOwnedPropertyByCustomerIdRequest, GetAllCustomerOwnedPropertyByCustomerIdResponse>
    {
        private readonly ICustomerOwnedPropertyReadRepository _customerOwnedPropertyReadRepository;

        public GetAllCustomerOwnedPropertyByCustomerIdHandler(ICustomerOwnedPropertyReadRepository customerOwnedPropertyReadRepository)
        {
            _customerOwnedPropertyReadRepository = customerOwnedPropertyReadRepository;
        }

        public async Task<GetAllCustomerOwnedPropertyByCustomerIdResponse> Handle(GetAllCustomerOwnedPropertyByCustomerIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.CustomerOwnedProperty> customerOwnedProperties = _customerOwnedPropertyReadRepository.GetWhere(e=>e.CustomerId == request.CustomerId && e.IsDeleted == false);
            return await Task.FromResult(new GetAllCustomerOwnedPropertyByCustomerIdResponse()
            {
                Data = customerOwnedProperties,
                Message = $"{customerOwnedProperties.Count()} adet data getirildi",
                Success = true
            });
        }
    }
}
