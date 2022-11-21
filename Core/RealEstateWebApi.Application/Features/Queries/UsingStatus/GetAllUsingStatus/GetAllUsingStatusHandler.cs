using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.UsingStatus.GetAllUsingStatus
{
    public class GetAllUsingStatusHandler : IRequestHandler<GetAllUsingStatusRequest, GetAllUsingStatusResponse>
    {
        private readonly IUsingStatusReadRepository _usingStatusReadRepository;

        public GetAllUsingStatusHandler(IUsingStatusReadRepository usingStatusReadRepository)
        {
            _usingStatusReadRepository = usingStatusReadRepository;
        }

        public async Task<GetAllUsingStatusResponse> Handle(GetAllUsingStatusRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.UsingStatus> usingStatuses = _usingStatusReadRepository.GetWhere(x => x.IsDeleted == false).OrderBy(e=>e.Title);
            return await Task.FromResult(new GetAllUsingStatusResponse()
            {
                Message = $"{usingStatuses.Count()} adet data getirildi",
                Success = true,
                Data = usingStatuses
            });
        }
    }
}
