using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.CustomerSearchShortProperty.GetAllCustomerSearchShortPropertyByCustomerId
{
    public class GetAllCustomerSearchShortPropertyByCustomerIdHandler : IRequestHandler<GetAllCustomerSearchShortPropertyByCustomerIdRequest, GetAllCustomerSearchShortPropertyByCustomerIdResponse>
    {
        private readonly ICustomerSearchShortPropertyReadRepository _customerSearchShortPropertyReadRepository;

        public GetAllCustomerSearchShortPropertyByCustomerIdHandler(ICustomerSearchShortPropertyReadRepository customerSearchShortPropertyReadRepository)
        {
            _customerSearchShortPropertyReadRepository = customerSearchShortPropertyReadRepository;
        }

        public async Task<GetAllCustomerSearchShortPropertyByCustomerIdResponse> Handle(GetAllCustomerSearchShortPropertyByCustomerIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.CustomerSearchShortProperty> customerSearchShortProperties = _customerSearchShortPropertyReadRepository.GetWhere(e=>e.CustomerId == request.CustomerId && e.IsDeleted == false);
            return await Task.FromResult(new GetAllCustomerSearchShortPropertyByCustomerIdResponse()
            {
                Data = customerSearchShortProperties,
                Message = $"{customerSearchShortProperties.Count()} adet data getirildi",
                Success = true
            });
        }
    }
}
