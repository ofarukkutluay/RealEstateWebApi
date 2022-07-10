using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.LocationSupport.GetAllDistrictByCitykey
{
    public class GetAllDistrictByCityKeyHandler : IRequestHandler<GetAllDistrictByCityKeyRequest, GetAllDistrictByCityKeyResponse>
    {
        private readonly IDistrictReadRepository _districtReadRepository;

        public GetAllDistrictByCityKeyHandler(IDistrictReadRepository districtReadRepository)
        {
            _districtReadRepository = districtReadRepository;
        }

        public async Task<GetAllDistrictByCityKeyResponse> Handle(GetAllDistrictByCityKeyRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.District> districts = _districtReadRepository.GetWhere(e => e.CityKey == request.CityKey).OrderBy(e => e.Name);
            return await Task.FromResult(new GetAllDistrictByCityKeyResponse()
            {
                Message = $"{districts.Count()} adet district getirildi.",
                Success = true,
                Data = districts
            });
        }
    }
}
