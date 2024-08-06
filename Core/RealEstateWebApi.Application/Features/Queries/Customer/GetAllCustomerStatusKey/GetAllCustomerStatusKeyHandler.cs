using MediatR;
using RealEstateWebApi.Domain.Enums;

namespace RealEstateWebApi.Application.Features.Queries.GetAllCustomerStatusKey;

public class GetAllCustomerStatusKeyHandler : IRequestHandler<GetAllCustomerStatusKeyRequest, GetAllCustomerStatusKeyResponse>
{
    public Task<GetAllCustomerStatusKeyResponse> Handle(GetAllCustomerStatusKeyRequest request, CancellationToken cancellationToken)
    {
        IEnumerable<string> result = typeof(CustomerStatusKey).GetFields().Select(f=>f.Name);
        return Task.FromResult(new GetAllCustomerStatusKeyResponse{
            Data = result,
            TotalDataCount = result.Count(),
            Success = true,
            Message = "Tüm data getirldi."
        });
    }
}
