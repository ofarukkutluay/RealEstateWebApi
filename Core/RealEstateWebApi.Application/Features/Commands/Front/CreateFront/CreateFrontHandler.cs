using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.Front.CreateFront
{
    public class CreateFrontHandler : IRequestHandler<CreateFrontRequest, CreateFrontResponse>
    {
        private readonly IFrontReadRepository _frontReadRepository;
        private readonly IFrontWriteRepository _frontWriteRepository;
        private readonly IMapper _mapper;
        public CreateFrontHandler(IFrontReadRepository frontReadRepository, IFrontWriteRepository frontWriteRepository, IMapper mapper)
        {
            _frontReadRepository = frontReadRepository;
            _frontWriteRepository = frontWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateFrontResponse> Handle(CreateFrontRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Front front = await _frontReadRepository.GetSingleAsync(x=>x.Title.ToLower()==request.Title.ToLower() && x.IsDeleted == false);
            if(front != null)
                return new CreateFrontResponse()
                {
                    Message = "Bu title da deed status bulunmaktadır.",
                    Success = false
                };
            front = _mapper.Map<Domain.Entities.Front>(request);
            var result = await _frontWriteRepository.AddAndSaveAsync(front);
            if(result == null)
                return new CreateFrontResponse()
                {
                    Success = false,
                    Message = "Db ye kayıt edilirken bir hata alındı"
                };

            return new CreateFrontResponse()
            {
                Message = $"{result.Id} id li kayıt edildi",
                Success = true
            };
            
        }
    }
}
