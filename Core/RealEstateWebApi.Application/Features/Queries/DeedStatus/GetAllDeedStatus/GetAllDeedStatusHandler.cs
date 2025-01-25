using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.DeedStatus.GetAllDeedStatus
{
    public class GetAllDeedStatusHandler : IRequestHandler<GetAllDeedStatusRequest, GetAllDeedStatusResponse>
    {
        private readonly IDeedStatusReadRepository _deedStatusReadRepository;

        public GetAllDeedStatusHandler(IDeedStatusReadRepository deedStatusReadRepository)
        {
            _deedStatusReadRepository = deedStatusReadRepository;
        }

        public async Task<GetAllDeedStatusResponse> Handle(GetAllDeedStatusRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.DeedStatus> deedStatuses = _deedStatusReadRepository.GetAll(false).OrderBy(e=>e.Title);
            return await Task.FromResult(new GetAllDeedStatusResponse()
            {
                Message = $"{deedStatuses.Count()} adet data getirildi",
                Success = true,
                Data = deedStatuses
            });
        }
    }
}
