using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Queries.EntrySubType.GetAllEntrySubTypeByEntryTypeId
{
    public class GetAllEntrySubTypeByEntryTypeIdHandler : IRequestHandler<GetAllEntrySubTypeByEntryTypeIdRequest, GetAllEntrySubTypeByEntryTypeIdResponse>
    {
        private readonly IEntrySubTypeReadRepository _entryTypeReadRepository;

        public GetAllEntrySubTypeByEntryTypeIdHandler(IEntrySubTypeReadRepository entryTypeReadRepository)
        {
            _entryTypeReadRepository = entryTypeReadRepository;
        }

        public async Task<GetAllEntrySubTypeByEntryTypeIdResponse> Handle(GetAllEntrySubTypeByEntryTypeIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.EntrySubType> entrySubTypes = _entryTypeReadRepository.GetWhere(e=>e.EntryTypeId == request.EntryTypeId).OrderBy(e=>e.Id);
            return await Task.FromResult(new GetAllEntrySubTypeByEntryTypeIdResponse()
            {
                Message = $"{entrySubTypes.Count()} adet data getirildi",
                Success = true,
                Data = entrySubTypes
            });
        }
    }
}
