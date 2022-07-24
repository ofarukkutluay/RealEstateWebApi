using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.ShortProperty.GetAllShortProperty
{
    public class GetAllShortPropertyHandler : IRequestHandler<GetAllShortPropertyRequest, GetAllShortPropertyResponse>
    {
        private readonly IShortPropertyReadRepository _shortPropertyReadRepository;

        public GetAllShortPropertyHandler(IShortPropertyReadRepository shortPropertyReadRepository)
        {
            _shortPropertyReadRepository = shortPropertyReadRepository;
        }

        public async Task<GetAllShortPropertyResponse> Handle(GetAllShortPropertyRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.ShortProperty> shortProperties = _shortPropertyReadRepository.GetAll();
            return await Task.FromResult(new GetAllShortPropertyResponse()
            {
                Message = $"{shortProperties.Count()} adet data getirildi",
                Success = true,
                Data = shortProperties
            });
        }
    }
}
