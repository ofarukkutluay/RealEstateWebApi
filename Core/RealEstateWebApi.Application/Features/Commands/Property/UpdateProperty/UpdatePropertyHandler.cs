using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.Property.UpdateProperty
{
    public class UpdatePropertyHandler : IRequestHandler<UpdatePropertyRequest, UpdatePropertyResponse>
    {
        private readonly IPropertyReadRepository _propertyReadRepository;
        private readonly IPropertyWriteRepository _propertyWriteRepository;
        public UpdatePropertyHandler(IPropertyReadRepository propertyReadRepository, IPropertyWriteRepository propertyWriteRepository)
        {
            _propertyReadRepository = propertyReadRepository;
            _propertyWriteRepository = propertyWriteRepository;
        }

        public async Task<UpdatePropertyResponse> Handle(UpdatePropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Property property = await _propertyReadRepository.GetByIdAsync(request.Id);
            if(property == null)
                return new UpdatePropertyResponse()
                {
                    Message = "Property bulunamadı",
                    Success = false
                };

            property.Title = String.IsNullOrEmpty(request.Title) ? property.Title : request.Title;
            property.Description = String.IsNullOrEmpty(request.Description) ? property.Description : request.Description;
            property.AgentId = request.AgentId;
            property.Aidat = request.Aidat;
            property.BalconyCount = request.BalconyCount;
            property.BathRoomCount = request.BathRoomCount;
            property.BuildingAge = request.BuildingAge;
            property.BuildingFloor = request.BuildingFloor;
            property.BuildingTotalFloor = request.BuildingTotalFloor;
            property.CityId = request.CityId;
            property.ClientId = request.ClientId;
            property.CompanyId = request.CompanyId;
            property.DeedStatusId = request.DeedStatusId;
            property.DistrictId = request.DistrictId;
            property.FrontId = request.FrontId;
            property.GarageCount = request.GarageCount;
            property.GrossSquareMeter = request.GrossSquareMeter;
            property.HeatingTypeId = request.HeatingTypeId;
            property.InternetTypeId = request.InternetTypeId;
            property.IsAvailableLoan = request.IsAvailableLoan;
            property.IsFurnished = request.IsFurnished;
            property.IsOnSite = request.IsOnSite;
            property.IsSmartHome = request.IsSmartHome;
            property.KonumIFrame = request.KonumIFrame;
            property.Landscape = request.Landscape;
            property.LivingRoomCount = request.LivingRoomCount;
            property.LocationLat = request.LocationLat;
            property.LocationLon = request.LocationLon;
            property.NeighborhoodId = request.NeighborhoodId;
            property.Price = request.Price;
            property.PropertyStatusId = request.PropertyStatusId;
            property.PropertyTypeId = request.PropertyTypeId;
            property.RoomCount = request.RoomCount;
            property.SiteName = request.SiteName;
            property.StreetId = request.StreetId;
            property.UsableSquareMeter = request.UsableSquareMeter;
            property.UsingStatusId = request.UsingStatusId;
            property.YoutubeLink = request.YoutubeLink;
            
            property.IsActive = request.IsActive;
            var result = await _propertyWriteRepository.SaveAsync();
            if(result<=0)
                return new UpdatePropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new UpdatePropertyResponse()
            {
                Message = "Property güncellendi",
                Success = true
            };
        }
    }
}
