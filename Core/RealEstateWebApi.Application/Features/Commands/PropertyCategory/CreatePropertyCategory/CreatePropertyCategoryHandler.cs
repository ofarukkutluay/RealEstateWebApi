using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.PropertyCategory.CreatePropertyCategory
{
    public class CreatePropertyCategoryHandler : IRequestHandler<CreatePropertyCategoryRequest, CreatePropertyCategoryResponse>
    {
        private readonly IPropertyCategoryReadRepository _propertyCategoryReadRepository;
        private readonly IPropertyCategoryWriteRepository _propertyCategoryWriteRepository;
        private readonly IMapper _mapper;
        public CreatePropertyCategoryHandler(IPropertyCategoryReadRepository propertyCategoryReadRepository, IPropertyCategoryWriteRepository propertyCategoryWriteRepository, IMapper mapper)
        {
            _propertyCategoryReadRepository = propertyCategoryReadRepository;
            _propertyCategoryWriteRepository = propertyCategoryWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreatePropertyCategoryResponse> Handle(CreatePropertyCategoryRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.PropertyCategory propertyCategory = await _propertyCategoryReadRepository.GetSingleAsync(x=>x.Title.ToLower()==request.Title.ToLower() && x.IsDeleted == false);
            if(propertyCategory != null)
                return new CreatePropertyCategoryResponse()
                {
                    Message = "Bu title da deed Category bulunmaktadır.", 
                    Success = false
                };

            propertyCategory = _mapper.Map<Domain.Entities.PropertyCategory>(request);
            var result = await _propertyCategoryWriteRepository.AddAndSaveAsync(propertyCategory);
            
            if(result == null)
                return new CreatePropertyCategoryResponse()
                {
                    Success = false,
                    Message = "Db ye kayıt edilirken bir hata alındı"
                };

            return new CreatePropertyCategoryResponse()
            {
                Message = $"{result.Id} id li kayıt edildi",
                Success = true
            };
            
        }
    }
}
