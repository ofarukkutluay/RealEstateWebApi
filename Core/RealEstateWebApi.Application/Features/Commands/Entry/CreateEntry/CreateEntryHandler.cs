﻿using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Domain;
using RealEstateWebApi.Domain.Enums;


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

            Domain.Entities.EntrySubType customerEntrySubType = await _entrySubTypeReadRepository.GetSingleAsync(x => x.Key == customer.StatusKey);

            Domain.Entities.EntrySubType entrySubType = await _entrySubTypeReadRepository.GetByIdAsync(request.EntrySubTypeId);
            //Domain.Entities.EntryType entryType = await _entryTypeReadRepository.GetByIdAsync(entrySubType.EntryTypeId);


            if(customerEntrySubType is null)
                customerEntrySubType = new Domain.Entities.EntrySubType{Id = 0};

            switch (entrySubType.Key)
            {
                case CustomerStatusKey.TAKIP:
                    customer.StatusKey = entrySubType.Key;
                    break;
                case CustomerStatusKey.GIRME:
                    customer.StatusKey = entrySubType.Key;
                    break;
                case CustomerStatusKey.YETKI:
                    customer.StatusKey = entrySubType.Key;
                    break;
                case CustomerStatusKey.YETKISIZ:
                    customer.StatusKey = entrySubType.Key;
                    break;
                case "PDOWN":
                    customer.StatusKey = CustomerStatusKey.TAKIP;
                    break;
                case "DOWN":
                    customer.StatusKey = "";
                    break;
                case CustomerStatusKey.ULSLMD:
                    customer.StatusKey = customerEntrySubType.Id == 0 ? entrySubType.Key : customer.StatusKey ;
                    break;  
                case "TLFN" or "ZYRT":
                    break;
                default:
                    customer.StatusKey = "";
                    break;
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
