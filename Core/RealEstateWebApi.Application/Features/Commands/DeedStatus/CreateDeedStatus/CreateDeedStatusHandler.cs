using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.DeedStatus.CreateDeedStatus
{
    public class CreateDeedStatusHandler : IRequestHandler<CreateDeedStatusRequest, CreateDeedStatusResponse>
    {
        private readonly IDeedStatusReadRepository _deedStatusReadRepository;
        private readonly IDeedStatusWriteRepository _deedStatusWriteRepository;
        private readonly IMapper _mapper;
        public CreateDeedStatusHandler(IDeedStatusReadRepository deedStatusReadRepository, IDeedStatusWriteRepository deedStatusWriteRepository, IMapper mapper)
        {
            _deedStatusReadRepository = deedStatusReadRepository;
            _deedStatusWriteRepository = deedStatusWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateDeedStatusResponse> Handle(CreateDeedStatusRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.DeedStatus deedStatus = await _deedStatusReadRepository.GetSingleAsync(x=>x.Title.ToLower()==request.Title.ToLower());
            if(deedStatus != null)
                return new CreateDeedStatusResponse()
                {
                    Message = "Bu title da deed status bulunmaktadır.",
                    Success = false
                };
            deedStatus = _mapper.Map<Domain.Entities.DeedStatus>(request);
            var result = await _deedStatusWriteRepository.AddAndSaveAsync(deedStatus);
            if(result == null)
                return new CreateDeedStatusResponse()
                {
                    Success = false,
                    Message = "Db ye kayıt edilirken bir hata alındı"
                };

            return new CreateDeedStatusResponse()
            {
                Message = $"{result.Id} id li kayıt edildi",
                Success = true
            };
            
        }
    }
}
