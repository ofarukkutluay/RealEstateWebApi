using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.ShortProperty.UpdateShortProperty
{
    public class UpdateShortPropertyHandler : IRequestHandler<UpdateShortPropertyRequest, UpdateShortPropertyResponse>
    {
        private readonly IShortPropertyReadRepository _shortPropertyReadRepository;
        private readonly IShortPropertyWriteRepository _shortPropertyWriteRepository;

        public UpdateShortPropertyHandler(IShortPropertyReadRepository shortPropertyReadRepository, IShortPropertyWriteRepository shortPropertyWriteRepository)
        {
            _shortPropertyReadRepository = shortPropertyReadRepository;
            _shortPropertyWriteRepository = shortPropertyWriteRepository;
        }

        public async Task<UpdateShortPropertyResponse> Handle(UpdateShortPropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.ShortProperty shortProperty = await _shortPropertyReadRepository.GetByIdAsync(request.Id);
            if(shortProperty == null)
                return new UpdateShortPropertyResponse()
                {
                    Message = "Data bulunamadı",
                    Success = false
                };

            shortProperty.StreetId = request.StreetId==default ? shortProperty.StreetId : request.StreetId;
            shortProperty.Price = request.Price == default ? shortProperty.Price:request.Price;
            shortProperty.PropertyTypeId = request.PropertyTypeId == default ? shortProperty.PropertyTypeId : request.PropertyTypeId;
            shortProperty.PropertyStatusId = request.PropertyStatusId == default ? shortProperty.PropertyStatusId : request.PropertyStatusId;
            shortProperty.CityId = request.CityId == default ? shortProperty.CityId : request.CityId;
            shortProperty.DistrictId = request.DistrictId == default ? shortProperty.DistrictId : request.DistrictId;
            shortProperty.Description = String.IsNullOrEmpty(request.Description) ? shortProperty.Description : request.Description;
            shortProperty.IsActive = request.IsActive;
            shortProperty.RoomCount = request.RoomCount == default ? shortProperty.RoomCount : request.RoomCount;
            shortProperty.LivingRoomCount = request.LivingRoomCount == default ? shortProperty.LivingRoomCount : request.LivingRoomCount;
            var result = await _shortPropertyWriteRepository.SaveAsync();
            if(result<0)
                return new UpdateShortPropertyResponse()
                {
                    Message = "Db ye kayıt edilrken bir hata alındı",
                    Success = false
                };

            return new UpdateShortPropertyResponse()
            {
                Message = "Data güncellendi",
                Success = true
            };
        }
    }
}
