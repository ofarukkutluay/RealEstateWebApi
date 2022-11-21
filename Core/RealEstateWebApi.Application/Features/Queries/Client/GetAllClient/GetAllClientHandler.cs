using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Client.GetAllClient
{
    public class GetAllClientHandler : IRequestHandler<GetAllClientRequest,GetAllClientResponse>
    {
        private readonly IClientReadRepository _clientReadRepository;

        public GetAllClientHandler(IClientReadRepository clientReadRepository)
        {
            _clientReadRepository = clientReadRepository;
        }

        public Task<GetAllClientResponse> Handle(GetAllClientRequest request, CancellationToken cancellationToken)
        {
            var result = _clientReadRepository.GetWhere(x=>x.IsDeleted == false).AsEnumerable();
            return Task.FromResult(new GetAllClientResponse()
            {
                Data = result,
                Message = "Tüm clients getirildi",
                Success = true
            });
        }
    }
}
