using System.Collections.Generic;
using MediatR;
using RealEstateWebApi.Application.DTOs;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.Entry.GetAllEntryDtoByCustomerId
{
    public class GetAllEntryDtoByCustomerIdHandler : IRequestHandler<GetAllEntryDtoByCustomerIdRequest, GetAllEntryDtoByCustomerIdResponse>
    {
        private readonly IEntryReadRepository _entryReadRepository;

        public GetAllEntryDtoByCustomerIdHandler(IEntryReadRepository entryReadRepository)
        {
            _entryReadRepository = entryReadRepository;
        }

        public async Task<GetAllEntryDtoByCustomerIdResponse> Handle(GetAllEntryDtoByCustomerIdRequest request, CancellationToken cancellationToken)
        {
            IQueryable<EntryDto> entries = _entryReadRepository.GetEntryDtoByCustomerId(request.CustomerId).OrderByDescending(e => e.CreatedDate);
            IEnumerable<EntryDto> sizedEntries = entries.Skip(request.PageIndex * request.PageSize).Take(request.PageSize).AsEnumerable();
            return await Task.FromResult(new GetAllEntryDtoByCustomerIdResponse()
            {
                Data = sizedEntries,
                TotalDataCount = entries.Count(),
                Message = $"{sizedEntries.Count()} adet data getirildi",
                Success = true
            });
        }
    }
}
