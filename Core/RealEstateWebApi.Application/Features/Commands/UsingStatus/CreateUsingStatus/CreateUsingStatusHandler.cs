using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.UsingStatus.CreateUsingStatus
{
    public class CreateUsingStatusHandler : IRequestHandler<CreateUsingStatusRequest, CreateUsingStatusResponse>
    {
        private readonly IUsingStatusReadRepository _usingStatusReadRepository;
        private readonly IUsingStatusWriteRepository _usingStatusWriteRepository;
        private readonly IMapper _mapper;
        public CreateUsingStatusHandler(IUsingStatusReadRepository usingStatusReadRepository, IUsingStatusWriteRepository usingStatusWriteRepository, IMapper mapper)
        {
            _usingStatusReadRepository = usingStatusReadRepository;
            _usingStatusWriteRepository = usingStatusWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateUsingStatusResponse> Handle(CreateUsingStatusRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.UsingStatus usingStatus = await _usingStatusReadRepository.GetSingleAsync(x=>x.Title.ToLower()==request.Title.ToLower());
            if(usingStatus != null)
                return new CreateUsingStatusResponse()
                {
                    Message = "Bu title da deed status bulunmaktadır.", 
                    Success = false
                };

            usingStatus = _mapper.Map<Domain.Entities.UsingStatus>(request);
            var result = await _usingStatusWriteRepository.AddAndSaveAsync(usingStatus);
            
            if(result == null)
                return new CreateUsingStatusResponse()
                {
                    Success = false,
                    Message = "Db ye kayıt edilirken bir hata alındı"
                };

            return new CreateUsingStatusResponse()
            {
                Message = $"{result.Id} id li kayıt edildi",
                Success = true
            };
            
        }
    }
}
