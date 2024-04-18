using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.LocationSupport.GetAllCity
{
    public class GetAllCityHandler : IRequestHandler<GetAllCityRequest, GetAllCityResponse>
    {
        private readonly ICityReadRepository _cityReadRepository;

        public GetAllCityHandler(ICityReadRepository cityReadRepository)
        {
            _cityReadRepository = cityReadRepository;
        }

        public async Task<GetAllCityResponse> Handle(GetAllCityRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.City> cities = _cityReadRepository.GetAll(false).OrderBy(e=>e.Id);
            return await Task.FromResult(new GetAllCityResponse()
            {
                Message = $"{cities.Count()} data getirildi",
                Success = true,
                Data = cities
            });
        }
    }
}
