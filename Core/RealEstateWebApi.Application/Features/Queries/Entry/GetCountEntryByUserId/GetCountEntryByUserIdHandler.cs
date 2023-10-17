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
            DateTime firstdate = DateTime.FromBinary(request.FirstDate).Date;
            
            if (request.LastDate == null)
            {
                result = _entryReadRepository.GetWhere(x => x.UserId == request.UserId && x.CreatedDate.Date == firstdate).Count();
            } else
            {
                DateTime lastdate = DateTime.FromBinary((long)request.LastDate).Date;
                result = _entryReadRepository.GetWhere(x => x.UserId == request.UserId && x.CreatedDate.Date >= firstdate && x.CreatedDate.Date <= lastdate).Count();
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

