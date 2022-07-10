using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.DeedStatus.DeleteDeedStatus
{
    public class DeleteDeedStatusHandler : IRequestHandler<DeleteDeedStatusRequest, DeleteDeedStatusResponse>
    {
        private readonly IDeedStatusReadRepository _deedStatusReadRepository;
        private readonly IDeedStatusWriteRepository _deedStatusWriteRepository;

        public DeleteDeedStatusHandler(IDeedStatusReadRepository deedStatusReadRepository, IDeedStatusWriteRepository deedStatusWriteRepository)
        {
            _deedStatusReadRepository = deedStatusReadRepository;
            _deedStatusWriteRepository = deedStatusWriteRepository;
        }

        public async Task<DeleteDeedStatusResponse> Handle(DeleteDeedStatusRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.DeedStatus deedStatus = await _deedStatusReadRepository.GetByIdAsync(request.Id);
            if(deedStatus == null)
                return new DeleteDeedStatusResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            await _deedStatusWriteRepository.RemoveAsync(request.Id);
            var result = await _deedStatusWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteDeedStatusResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new DeleteDeedStatusResponse()
            {
                Message = "Data silindi",
                Success = true
            };
        }
    }
}
