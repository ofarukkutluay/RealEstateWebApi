using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Entry.GetAllEntryByCustomerId
{
    public class GetAllEntryByCustomerIdHandler : IRequestHandler<GetAllEntryByCustomerIdRequest, GetAllEntryByCustomerIdResponse>
    {
        private readonly IEntryReadRepository _entryReadRepository;

        public GetAllEntryByCustomerIdHandler(IEntryReadRepository entryReadRepository)
        {
            _entryReadRepository = entryReadRepository;
        }

        public async Task<GetAllEntryByCustomerIdResponse> Handle(GetAllEntryByCustomerIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.Entry> entries = _entryReadRepository.GetWhere(e=>e.CustomerId == request.CustomerId && e.IsDeleted == false );
            return await Task.FromResult(new GetAllEntryByCustomerIdResponse()
            {
                Data = entries,
                Message = $"{entries.Count()} adet data getirildi",
                Success = true
            });
        }
    }
}
