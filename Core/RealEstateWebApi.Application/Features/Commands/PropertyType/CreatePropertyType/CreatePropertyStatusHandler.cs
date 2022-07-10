using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.PropertyType.CreatePropertyType
{
    public class CreatePropertyTypeHandler : IRequestHandler<CreatePropertyTypeRequest, CreatePropertyTypeResponse>
    {
        private readonly IPropertyTypeReadRepository _propertyTypeReadRepository;
        private readonly IPropertyTypeWriteRepository _propertyTypeWriteRepository;
        private readonly IMapper _mapper;
        public CreatePropertyTypeHandler(IPropertyTypeReadRepository propertyTypeReadRepository, IPropertyTypeWriteRepository propertyTypeWriteRepository, IMapper mapper)
        {
            _propertyTypeReadRepository = propertyTypeReadRepository;
            _propertyTypeWriteRepository = propertyTypeWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreatePropertyTypeResponse> Handle(CreatePropertyTypeRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.PropertyType propertyType = await _propertyTypeReadRepository.GetSingleAsync(x=>x.Title.ToLower()==request.Title.ToLower());
            if(propertyType != null)
                return new CreatePropertyTypeResponse()
                {
                    Message = "Bu title da deed Type bulunmaktadır.", 
                    Success = false
                };

            propertyType = _mapper.Map<Domain.Entities.PropertyType>(request);
            var result = await _propertyTypeWriteRepository.AddAndSaveAsync(propertyType);
            
            if(result == null)
                return new CreatePropertyTypeResponse()
                {
                    Success = false,
                    Message = "Db ye kayıt edilirken bir hata alındı"
                };

            return new CreatePropertyTypeResponse()
            {
                Message = $"{result.Id} id li kayıt edildi",
                Success = true
            };
            
        }
    }
}
