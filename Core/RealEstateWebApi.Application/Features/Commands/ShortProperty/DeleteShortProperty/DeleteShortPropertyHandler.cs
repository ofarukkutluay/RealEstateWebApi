using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.ShortProperty.DeleteShortProperty
{
    public class DeleteShortPropertyHandler : IRequestHandler<DeleteShortPropertyRequest, DeleteShortPropertyResponse>
    {
        private readonly IShortPropertyWriteRepository _shortPropertyWriteRepository;
        private readonly IShortPropertyReadRepository _shortPropertyReadRepository;

        public DeleteShortPropertyHandler(IShortPropertyWriteRepository shortPropertyWriteRepository, IShortPropertyReadRepository shortPropertyReadRepository)
        {
            _shortPropertyWriteRepository = shortPropertyWriteRepository;
            _shortPropertyReadRepository = shortPropertyReadRepository;
        }

        public async Task<DeleteShortPropertyResponse> Handle(DeleteShortPropertyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.ShortProperty shortProperty = await _shortPropertyReadRepository.GetByIdAsync(request.Id);
            if (shortProperty == null)
                return new DeleteShortPropertyResponse()
                {
                    Message = "Data bulunamadı",
                    Success = false
                };
            shortProperty.IsDeleted = true;
            var result = await _shortPropertyWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteShortPropertyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };

            return new DeleteShortPropertyResponse()
            {
                Message ="Data silindi",
                Success = true
            };
        }
    }
}
