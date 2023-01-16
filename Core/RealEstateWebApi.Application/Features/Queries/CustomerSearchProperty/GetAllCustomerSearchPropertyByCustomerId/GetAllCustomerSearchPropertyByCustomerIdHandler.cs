using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.CustomerSearchProperty.GetAllCustomerSearchPropertyByCustomerId
{
    public class GetAllCustomerSearchPropertyByCustomerIdHandler : IRequestHandler<GetAllCustomerSearchPropertyByCustomerIdRequest, GetAllCustomerSearchPropertyByCustomerIdResponse>
    {
        private readonly ICustomerSearchPropertyReadRepository _customerSearchPropertyReadRepository;

        public GetAllCustomerSearchPropertyByCustomerIdHandler(ICustomerSearchPropertyReadRepository customerSearchPropertyReadRepository)
        {
            _customerSearchPropertyReadRepository = customerSearchPropertyReadRepository;
        }

        public async Task<GetAllCustomerSearchPropertyByCustomerIdResponse> Handle(GetAllCustomerSearchPropertyByCustomerIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.CustomerSearchProperty> customerSearchProperties = _customerSearchPropertyReadRepository.GetWhere(e=>e.CustomerId == request.CustomerId && e.IsDeleted == false);
            return await Task.FromResult(new GetAllCustomerSearchPropertyByCustomerIdResponse()
            {
                Data = customerSearchProperties,
                Message = $"{customerSearchProperties.Count()} adet data getirildi",
                Success = true
            });
        }
    }
}
