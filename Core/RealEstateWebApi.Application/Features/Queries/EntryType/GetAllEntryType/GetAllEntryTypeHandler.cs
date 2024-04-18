using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.EntryType.GetAllEntryType
{
    public class GetAllEntryTypeHandler : IRequestHandler<GetAllEntryTypeRequest, GetAllEntryTypeResponse>
    {
        private readonly IEntryTypeReadRepository _entryTypeReadRepository;

        public GetAllEntryTypeHandler(IEntryTypeReadRepository entryTypeReadRepository)
        {
            _entryTypeReadRepository = entryTypeReadRepository;
        }

        public async Task<GetAllEntryTypeResponse> Handle(GetAllEntryTypeRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.EntryType> entryTypes = _entryTypeReadRepository.GetAll(false).OrderBy(e=>e.Id);
            return await Task.FromResult(new GetAllEntryTypeResponse()
            {
                Message = $"{entryTypes.Count()} adet data getirildi",
                Success = true,
                Data = entryTypes
            });
        }
    }
}
