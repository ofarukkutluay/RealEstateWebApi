using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.PropertyType.GetAllPropertyType
{
    public class GetAllPropertyTypeHandler : IRequestHandler<GetAllPropertyTypeRequest, GetAllPropertyTypeResponse>
    {
        private readonly IPropertyTypeReadRepository _propertyTypeReadRepository;

        public GetAllPropertyTypeHandler(IPropertyTypeReadRepository propertyTypeReadRepository)
        {
            _propertyTypeReadRepository = propertyTypeReadRepository;
        }

        public async Task<GetAllPropertyTypeResponse> Handle(GetAllPropertyTypeRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.PropertyType> propertyTypees = _propertyTypeReadRepository.GetWhere(x=>x.PropertyStatusId == request.PropertyStatusId);
            return await Task.FromResult(new GetAllPropertyTypeResponse()
            {
                Message = $"{propertyTypees.Count()} adet data getirildi",
                Success = true,
                Data = propertyTypees
            });
        }
    }
}
