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

        public DeleteShortPropertyHandler(IShortPropertyWriteRepository shortPropertyWriteRepository)
        {
            _shortPropertyWriteRepository = shortPropertyWriteRepository;
        }

        public async Task<DeleteShortPropertyResponse> Handle(DeleteShortPropertyRequest request, CancellationToken cancellationToken)
        {
            await _shortPropertyWriteRepository.RemoveAsync(request.Id);
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
