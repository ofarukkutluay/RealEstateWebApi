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
            IEnumerable<EntryDto> entries = _entryReadRepository.GetEntryDtoByCustomerId(request.CustomerId).OrderByDescending(e => e.CreatedDate)
                .Skip((request.Page - 1) * request.PageSize).Take(request.PageSize);
            return await Task.FromResult(new GetAllEntryDtoByCustomerIdResponse()
            {
                Data = entries,
                Message = $"{entries.Count()} adet data getirildi",
                Success = true
            });
        }
    }
}
