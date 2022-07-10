using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.InternetType.CreateInternetType
{
    public class CreateInternetTypeHandler : IRequestHandler<CreateInternetTypeRequest, CreateInternetTypeResponse>
    {
        private readonly IInternetTypeReadRepository _internetTypeReadRepository;
        private readonly IInternetTypeWriteRepository _internetTypeWriteRepository;
        private readonly IMapper _mapper;
        public CreateInternetTypeHandler(IInternetTypeReadRepository internetTypeReadRepository, IInternetTypeWriteRepository internetTypeWriteRepository, IMapper mapper)
        {
            _internetTypeReadRepository = internetTypeReadRepository;
            _internetTypeWriteRepository = internetTypeWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateInternetTypeResponse> Handle(CreateInternetTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.InternetType internetType = await _internetTypeReadRepository.GetSingleAsync(x=>x.Title.ToLower()==request.Title.ToLower());
            if(internetType != null)
                return new CreateInternetTypeResponse()
                {
                    Message = "Bu title da deed status bulunmaktadır.", 
                    Success = false
                };

            internetType = _mapper.Map<Domain.Entities.InternetType>(request);
            var result = await _internetTypeWriteRepository.AddAndSaveAsync(internetType);
            
            if(result == null)
                return new CreateInternetTypeResponse()
                {
                    Success = false,
                    Message = "Db ye kayıt edilirken bir hata alındı"
                };

            return new CreateInternetTypeResponse()
            {
                Message = $"{result.Id} id li kayıt edildi",
                Success = true
            };
            
        }
    }
}
