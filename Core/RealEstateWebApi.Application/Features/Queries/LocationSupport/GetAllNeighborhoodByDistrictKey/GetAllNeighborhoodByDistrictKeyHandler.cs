using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.LocationSupport.GetAllNeighborhoodByDistrictKey
{
    public class GetAllNeighborhoodByDistrictKeyHandler : IRequestHandler<GetAllNeighborhoodByDistrictKeyRequest, GetAllNeighborhoodByDistrictKeyResponse>
    {
        private readonly INeighborhoodReadRepository _neighborhoodReadRepository;

        public GetAllNeighborhoodByDistrictKeyHandler(INeighborhoodReadRepository neighborhoodReadRepository)
        {
            _neighborhoodReadRepository = neighborhoodReadRepository;
        }

        public async Task<GetAllNeighborhoodByDistrictKeyResponse> Handle(GetAllNeighborhoodByDistrictKeyRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.Neighborhood> neighborhoods = _neighborhoodReadRepository.GetWhere(e=> e.DistrictKey == request.DistrictKey).OrderBy(e=>e.Name);
            return await Task.FromResult(new GetAllNeighborhoodByDistrictKeyResponse()
            {
                Message = $"{neighborhoods.Count()} adet data getirildi.",
                Success = true,
                Data = neighborhoods
            });

        }
    }
}
