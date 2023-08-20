using System;
using MediatR;
using RealEstateWebApi.Application.Repositories;

namespace RealEstateWebApi.Application.Features.Queries.Entry.GetCountEntryByUserId
{
    public class GetCountEntryByUserIdHandler : IRequestHandler<GetCountEntryByUserIdRequest, GetCountEntryByUserIdResponse>
    {
        private readonly IEntryReadRepository _entryReadRepository;

        public GetCountEntryByUserIdHandler(IEntryReadRepository entryReadRepository)
        {
            _entryReadRepository = entryReadRepository;
        }

        public async Task<GetCountEntryByUserIdResponse> Handle(GetCountEntryByUserIdRequest request, CancellationToken cancellationToken)
        {
            int result;
            if(request.LastDate == null)
            {
                result = _entryReadRepository.GetWhere(x => x.UserId == request.UserId && x.CreatedDate.Date == request.FirstDate.Date).Count();
            } else
            {
                result = _entryReadRepository.GetWhere(x => x.UserId == request.UserId && x.CreatedDate.Date >= request.FirstDate.Date && x.CreatedDate.Date <= request.LastDate.GetValueOrDefault().Date).Count();
            }

            return new GetCountEntryByUserIdResponse()
            {
                Data = result,
                Success = true,
                Message = "Data Getirildi"
            };

        }
    }
}

