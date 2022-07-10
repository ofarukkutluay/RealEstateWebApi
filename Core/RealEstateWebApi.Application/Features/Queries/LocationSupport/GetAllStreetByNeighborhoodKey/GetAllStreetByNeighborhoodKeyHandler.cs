using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.LocationSupport.GetAllStreetByNeighborhoodKey
{
    public class GetAllStreetByNeighborhoodKeyHandler : IRequestHandler<GetAllStreetByNeighborhoodKeyRequest, GetAllStreetByNeighborhoodKeyResponse>
    {
        private readonly IStreetReadRepository _streetReadRepository;

        public GetAllStreetByNeighborhoodKeyHandler(IStreetReadRepository streetReadRepository)
        {
            _streetReadRepository = streetReadRepository;
        }

        public async Task<GetAllStreetByNeighborhoodKeyResponse> Handle(GetAllStreetByNeighborhoodKeyRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.Street> streets = _streetReadRepository.GetWhere(e=>e.NeighborhoodKey == request.NeighborhoodKey).OrderBy(e=>e.Name);
            return await Task.FromResult(new GetAllStreetByNeighborhoodKeyResponse()
            {
                Message = $"{streets.Count()} adet data getirldi",
                Success = true,
                Data = streets
            });
        }
    }
}
