using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.HeatingType.GetAllHeatingType
{
    public class GetAllHeatingTypeHandler : IRequestHandler<GetAllHeatingTypeRequest, GetAllHeatingTypeResponse>
    {
        private readonly IHeatingTypeReadRepository _heatingTypeReadRepository;

        public GetAllHeatingTypeHandler(IHeatingTypeReadRepository heatingTypeReadRepository)
        {
            _heatingTypeReadRepository = heatingTypeReadRepository;
        }

        public async Task<GetAllHeatingTypeResponse> Handle(GetAllHeatingTypeRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.HeatingType> heatingTypees = _heatingTypeReadRepository.GetAll().OrderBy(e=>e.Title);
            return await Task.FromResult(new GetAllHeatingTypeResponse()
            {
                Message = $"{heatingTypees.Count()} adet data getirildi",
                Success = true,
                Data = heatingTypees
            });
        }
    }
}
