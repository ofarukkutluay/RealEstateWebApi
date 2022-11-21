using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.PropertyStatus.CreatePropertyStatus
{
    public class CreatePropertyStatusHandler : IRequestHandler<CreatePropertyStatusRequest, CreatePropertyStatusResponse>
    {
        private readonly IPropertyStatusReadRepository _propertyStatusReadRepository;
        private readonly IPropertyStatusWriteRepository _propertyStatusWriteRepository;
        private readonly IMapper _mapper;
        public CreatePropertyStatusHandler(IPropertyStatusReadRepository propertyStatusReadRepository, IPropertyStatusWriteRepository propertyStatusWriteRepository, IMapper mapper)
        {
            _propertyStatusReadRepository = propertyStatusReadRepository;
            _propertyStatusWriteRepository = propertyStatusWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreatePropertyStatusResponse> Handle(CreatePropertyStatusRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.PropertyStatus propertyStatus = await _propertyStatusReadRepository.GetSingleAsync(x=>x.Title.ToLower()==request.Title.ToLower() && x.IsDeleted == false);
            if(propertyStatus != null)
                return new CreatePropertyStatusResponse()
                {
                    Message = "Bu title da deed status bulunmaktadır.", 
                    Success = false
                };

            propertyStatus = _mapper.Map<Domain.Entities.PropertyStatus>(request);
            var result = await _propertyStatusWriteRepository.AddAndSaveAsync(propertyStatus);
            
            if(result == null)
                return new CreatePropertyStatusResponse()
                {
                    Success = false,
                    Message = "Db ye kayıt edilirken bir hata alındı"
                };

            return new CreatePropertyStatusResponse()
            {
                Message = $"{result.Id} id li kayıt edildi",
                Success = true
            };
            
        }
    }
}
