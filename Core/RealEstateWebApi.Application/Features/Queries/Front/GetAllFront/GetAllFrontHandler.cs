using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.Front.GetAllFront
{
    public class GetAllFrontHandler : IRequestHandler<GetAllFrontRequest, GetAllFrontResponse>
    {
        private readonly IFrontReadRepository _frontReadRepository;

        public GetAllFrontHandler(IFrontReadRepository frontReadRepository)
        {
            _frontReadRepository = frontReadRepository;
        }

        public async Task<GetAllFrontResponse> Handle(GetAllFrontRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.Front> frontes = _frontReadRepository.GetAll().OrderBy(e=>e.Title);
            return await Task.FromResult(new GetAllFrontResponse()
            {
                Message = $"{frontes.Count()} adet data getirildi",
                Success = true,
                Data = frontes
            });
        }
    }
}
