using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.Property.DeleteProperty
{
    public class DeletePropertyHandler : IRequestHandler<DeletePropertyRequest, DeletePropertyResponse>
    {
        private readonly IPropertyReadRepository _propertyReadRepository;
        private readonly IPropertyWriteRepository _propertyWriteRepository;
        public DeletePropertyHandler(IPropertyReadRepository propertyReadRepository, IPropertyWriteRepository propertyWriteRepository)
        {
            _propertyReadRepository = propertyReadRepository;
            _propertyWriteRepository = propertyWriteRepository;
        }

        public async Task<DeletePropertyResponse> Handle(DeletePropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Property property = await _propertyReadRepository.GetByIdAsync(request.PropertyId);
            if(property == null)
                return new DeletePropertyResponse()
                {
                    Message = "Property bulunamadı",
                    Success = false
                };

            property.IsDeleted = true;
            var result = await _propertyWriteRepository.SaveAsync();
            if(result<=0)
                return new DeletePropertyResponse()
                {
                    Message = "Db ye kayıt edilerken bir hata oluştu",
                    Success=false
                };

            return new DeletePropertyResponse()
            {
                Message = "job title silindi",
                Success = true
            };
        }
    }
}
