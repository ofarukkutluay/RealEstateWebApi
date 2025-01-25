using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.JobTitle.UpdateJobTitle
{
    public class UpdateJobTitleHandler : IRequestHandler<UpdateJobTitleRequest, UpdateJobTitleResponse>
    {
        private readonly IJobTitleReadRepository _jobTitleReadRepository;
        private readonly IJobTitleWriteRepository _jobTitleWriteRepository;
        public UpdateJobTitleHandler(IJobTitleReadRepository jobTitleReadRepository, IJobTitleWriteRepository jobTitleWriteRepository)
        {
            _jobTitleReadRepository = jobTitleReadRepository;
            _jobTitleWriteRepository = jobTitleWriteRepository;
        }

        public async Task<UpdateJobTitleResponse> Handle(UpdateJobTitleRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.JobTitle jobTitle = await _jobTitleReadRepository.GetByIdAsync(request.Id);
            if(jobTitle == null)
                return new UpdateJobTitleResponse()
                {
                    Message = "Job title bulunamadı",
                    Success = false
                };

            jobTitle.Title = String.IsNullOrEmpty(request.Title) ? jobTitle.Title : request.Title;
            jobTitle.Description = String.IsNullOrEmpty(request.Description) ? jobTitle.Description : request.Description;
            jobTitle.IsActive = request.IsActive;
            var result = await _jobTitleWriteRepository.SaveAsync();
            if(result<=0)
                return new UpdateJobTitleResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new UpdateJobTitleResponse()
            {
                Message = "job title güncellendi",
                Success = true
            };
        }
    }
}
