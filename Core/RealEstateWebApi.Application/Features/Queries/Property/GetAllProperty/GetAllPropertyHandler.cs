using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.Property.GetAllProperty
{
    public class GetAllPropertyHandler : IRequestHandler<GetAllPropertyRequest, GetAllPropertyResponse>
    {
        private readonly IPropertyReadRepository _propertyReadRepository;

        public GetAllPropertyHandler(IPropertyReadRepository propertyReadRepository)
        {
            _propertyReadRepository = propertyReadRepository;
        }

        public async Task<GetAllPropertyResponse> Handle(GetAllPropertyRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.Property> propertyes = _propertyReadRepository.GetAll(false).OrderByDescending(e=>e.CreatedDate);
            return await Task.FromResult(new GetAllPropertyResponse()
            {
                Message = $"{propertyes.Count()} adet data getirildi",
                Success = true,
                Data = propertyes
            });
        }
    }
}
