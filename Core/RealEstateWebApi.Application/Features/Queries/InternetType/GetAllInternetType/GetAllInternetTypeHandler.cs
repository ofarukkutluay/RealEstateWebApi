using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.InternetType.GetAllInternetType
{
    public class GetAllInternetTypeHandler : IRequestHandler<GetAllInternetTypeRequest, GetAllInternetTypeResponse>
    {
        private readonly IInternetTypeReadRepository _internetTypeReadRepository;

        public GetAllInternetTypeHandler(IInternetTypeReadRepository internetTypeReadRepository)
        {
            _internetTypeReadRepository = internetTypeReadRepository;
        }

        public async Task<GetAllInternetTypeResponse> Handle(GetAllInternetTypeRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.InternetType> internetTypees = _internetTypeReadRepository.GetWhere(x => x.IsDeleted == false).OrderBy(e=>e.Title);
            return await Task.FromResult(new GetAllInternetTypeResponse()
            {
                Message = $"{internetTypees.Count()} adet data getirildi",
                Success = true,
                Data = internetTypees
            });
        }
    }
}
