using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.Customer.GetCustomerDtoById
{
    public class GetCustomerDtoByIdHandler : IRequestHandler<GetCustomerDtoByIdRequest, GetCustomerDtoByIdResponse>
    {
        private readonly ICustomerReadRepository _customerReadRepository;

        public GetCustomerDtoByIdHandler(ICustomerReadRepository customerReadRepository)
        {
            _customerReadRepository = customerReadRepository;
        }

        public async Task<GetCustomerDtoByIdResponse> Handle(GetCustomerDtoByIdRequest request, CancellationToken cancellationToken)
        {
            CustomerDto customer = _customerReadRepository.GetDtoById(request.Id);
            return await Task.FromResult( new GetCustomerDtoByIdResponse()
            {
                Data = customer,
                Success = true
            });
        }
    }
}
