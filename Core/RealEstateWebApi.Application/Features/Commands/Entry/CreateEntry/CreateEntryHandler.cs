using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.Entry.CreateEntry
{
    public class CreateEntryHandler : IRequestHandler<CreateEntryRequest, CreateEntryResponse>
    {
        private readonly IEntryWriteRepository _entryWriteRepository;
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;
        private readonly IEntryTypeReadRepository _entryTypeReadRepository;
        private readonly IEntrySubTypeReadRepository _entrySubTypeReadRepository;
        private readonly IMapper _mapper;
        public CreateEntryHandler(IEntryWriteRepository entryWriteRepository, IMapper mapper, ICustomerReadRepository customerReadRepository, ICustomerWriteRepository customerWriteRepository, IEntryTypeReadRepository entryTypeReadRepository, IEntrySubTypeReadRepository entrySubTypeReadRepository)
        {
            _entryWriteRepository = entryWriteRepository;
            _mapper = mapper;
            _customerReadRepository = customerReadRepository;
            _customerWriteRepository = customerWriteRepository;
            _entryTypeReadRepository = entryTypeReadRepository;
            _entrySubTypeReadRepository = entrySubTypeReadRepository;
        }

        public async Task<CreateEntryResponse> Handle(CreateEntryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Customer customer = await _customerReadRepository.GetByIdAsync(request.CustomerId);
            if (customer is null)
            {
                return new CreateEntryResponse()
                {
                    Success = false,
                    Message = "Db ye kayıt edilirken bir hata alındı"
                };
            }

            Domain.Entities.EntryType customerEntryType = await _entryTypeReadRepository.GetSingleAsync(x => x.Key == customer.StatusKey);

            Domain.Entities.EntrySubType entrySubType = await _entrySubTypeReadRepository.GetByIdAsync(request.EntrySubTypeId);
            Domain.Entities.EntryType entryType = await _entryTypeReadRepository.GetByIdAsync(entrySubType.EntryTypeId);
            if (entryType != null)
            {
                if (entrySubType.Key == "DOWN" && entryType.Id > 1)
                {
                    customer.StatusKey = (await _entryTypeReadRepository.GetByIdAsync(entryType.Id - 1)).Key;
                }
                else if (entrySubType.Key =="GDOWN")
                {
                    customer.StatusKey = "GRSM";
                }
                else if (entrySubType.Key == "PDOWN")
                {
                    customer.StatusKey = "PTNSYL";
                }
                else if (customerEntryType != null && customerEntryType.Id < entryType.Id)
                {

                    customer.StatusKey = entryType.Key;
                }
                else if (string.IsNullOrEmpty(customer.StatusKey) || customer.StatusKey == "YENI")
                {
                    customer.StatusKey = entryType.Key;
                }
            }

            await _customerWriteRepository.SaveAsync();

            Domain.Entities.Entry entry = _mapper.Map<Domain.Entities.Entry>(request);
            var result = await _entryWriteRepository.AddAndSaveAsync(entry);


            if (result == null)
                return new CreateEntryResponse()
                {
                    Success = false,
                    Message = "Db ye kayıt edilirken bir hata alındı"
                };

            return new CreateEntryResponse()
            {
                Message = $"{result.Id} id li kayıt edildi",
                Success = true
            };

        }
    }
}
