using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.PropertyStatus.GetAllPropertyStatus
{
    public class GetAllPropertyStatusHandler : IRequestHandler<GetAllPropertyStatusRequest, GetAllPropertyStatusResponse>
    {
        private readonly IPropertyStatusReadRepository _propertyStatusReadRepository;

        public GetAllPropertyStatusHandler(IPropertyStatusReadRepository propertyStatusReadRepository)
        {
            _propertyStatusReadRepository = propertyStatusReadRepository;
        }

        public async Task<GetAllPropertyStatusResponse> Handle(GetAllPropertyStatusRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.PropertyStatus> propertyStatuses = _propertyStatusReadRepository.GetWhere(x=>x.PropertyCategoryId == request.PropertyCategoryId);
            return await Task.FromResult(new GetAllPropertyStatusResponse()
            {
                Message = $"{propertyStatuses.Count()} adet data getirildi",
                Success = true,
                Data = propertyStatuses
            });
        }
    }
}
