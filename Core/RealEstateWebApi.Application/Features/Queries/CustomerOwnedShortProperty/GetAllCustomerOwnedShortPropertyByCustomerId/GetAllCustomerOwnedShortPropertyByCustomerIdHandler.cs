using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.CustomerOwnedShortProperty.GetAllCustomerOwnedShortPropertyByCustomerId
{
    public class GetAllCustomerOwnedShortPropertyByCustomerIdHandler : IRequestHandler<GetAllCustomerOwnedShortPropertyByCustomerIdRequest, GetAllCustomerOwnedShortPropertyByCustomerIdResponse>
    {
        private readonly ICustomerOwnedShortPropertyReadRepository _customerOwnedShortPropertyReadRepository;

        public GetAllCustomerOwnedShortPropertyByCustomerIdHandler(ICustomerOwnedShortPropertyReadRepository customerOwnedShortPropertyReadRepository)
        {
            _customerOwnedShortPropertyReadRepository = customerOwnedShortPropertyReadRepository;
        }

        public async Task<GetAllCustomerOwnedShortPropertyByCustomerIdResponse> Handle(GetAllCustomerOwnedShortPropertyByCustomerIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.CustomerOwnedShortProperty> customerOwnedShortProperties = _customerOwnedShortPropertyReadRepository.GetWhere(e=>e.CustomerId == request.CustomerId && e.IsDeleted == false);
            return await Task.FromResult(new GetAllCustomerOwnedShortPropertyByCustomerIdResponse()
            {
                Data = customerOwnedShortProperties,
                Message = $"{customerOwnedShortProperties.Count()} adet data getirildi",
                Success = true
            });
        }
    }
}
