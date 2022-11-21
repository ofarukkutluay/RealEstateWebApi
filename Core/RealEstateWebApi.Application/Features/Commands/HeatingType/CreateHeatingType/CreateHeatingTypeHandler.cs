using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.HeatingType.CreateHeatingType
{
    public class CreateHeatingTypeHandler : IRequestHandler<CreateHeatingTypeRequest, CreateHeatingTypeResponse>
    {
        private readonly IHeatingTypeReadRepository _heatingTypeReadRepository;
        private readonly IHeatingTypeWriteRepository _heatingTypeWriteRepository;
        private readonly IMapper _mapper;
        public CreateHeatingTypeHandler(IHeatingTypeReadRepository heatingTypeReadRepository, IHeatingTypeWriteRepository heatingTypeWriteRepository, IMapper mapper)
        {
            _heatingTypeReadRepository = heatingTypeReadRepository;
            _heatingTypeWriteRepository = heatingTypeWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateHeatingTypeResponse> Handle(CreateHeatingTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.HeatingType heatingType = await _heatingTypeReadRepository.GetSingleAsync(x=>x.Title.ToLower()==request.Title.ToLower() && x.IsDeleted == false);
            if(heatingType != null)
                return new CreateHeatingTypeResponse()
                {
                    Message = "Bu title da deed status bulunmaktadır.", 
                    Success = false
                };

            heatingType = _mapper.Map<Domain.Entities.HeatingType>(request);
            var result = await _heatingTypeWriteRepository.AddAndSaveAsync(heatingType);
            
            if(result == null)
                return new CreateHeatingTypeResponse()
                {
                    Success = false,
                    Message = "Db ye kayıt edilirken bir hata alındı"
                };

            return new CreateHeatingTypeResponse()
            {
                Message = $"{result.Id} id li kayıt edildi",
                Success = true
            };
            
        }
    }
}
