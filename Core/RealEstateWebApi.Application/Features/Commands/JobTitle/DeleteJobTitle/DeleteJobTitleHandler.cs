using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.JobTitle.DeleteJobTitle
{
    public class DeleteJobTitleHandler : IRequestHandler<DeleteJobTitleRequest, DeleteJobTitleResponse>
    {
        private readonly IJobTitleReadRepository _jobTitleReadRepository;
        private readonly IJobTitleWriteRepository _jobTitleWriteRepository;
        public DeleteJobTitleHandler(IJobTitleReadRepository jobTitleReadRepository, IJobTitleWriteRepository jobTitleWriteRepository)
        {
            _jobTitleReadRepository = jobTitleReadRepository;
            _jobTitleWriteRepository = jobTitleWriteRepository;
        }

        public async Task<DeleteJobTitleResponse> Handle(DeleteJobTitleRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.JobTitle jobTitle = await _jobTitleReadRepository.GetByIdAsync(request.JobTitleId);
            if(jobTitle == null)
                return new DeleteJobTitleResponse()
                {
                    Message = "JobTitle bulunamadı",
                    Success = false
                };

            await _jobTitleWriteRepository.RemoveAsync(request.JobTitleId);
            var result = await _jobTitleWriteRepository.SaveAsync();
            if(result<=0)
                return new DeleteJobTitleResponse()
                {
                    Message = "Db ye kayıt edilerken bir hata oluştu",
                    Success=false
                };

            return new DeleteJobTitleResponse()
            {
                Message = "job title silindi",
                Success = true
            };
        }
    }
}
