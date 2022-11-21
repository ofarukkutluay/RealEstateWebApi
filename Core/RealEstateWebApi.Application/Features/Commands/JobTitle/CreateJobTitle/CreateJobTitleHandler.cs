using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.JobTitle.CreateJobTitle
{
    public class CreateJobTitleHandler : IRequestHandler<CreateJobTitleRequest, CreateJobTitleResponse>
    {
        private readonly IJobTitleReadRepository _jobTitleReadRepository;
        private readonly IJobTitleWriteRepository _jobTitleWriteRepository;
        private readonly IMapper _mapper;
        public CreateJobTitleHandler(IJobTitleReadRepository jobTitleReadRepository, IJobTitleWriteRepository jobTitleWriteRepository, IMapper mapper)
        {
            _jobTitleReadRepository = jobTitleReadRepository;
            _jobTitleWriteRepository = jobTitleWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateJobTitleResponse> Handle(CreateJobTitleRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.JobTitle jobTitle = await _jobTitleReadRepository.GetSingleAsync(e=>e.Title.ToLower() == request.Title.ToLower() && e.CompanyId == request.CompanyId && e.IsDeleted==false);
            if(jobTitle != null)
                return new CreateJobTitleResponse()
                {
                    Message = "İlettiğiniz title ve companyId de jobTitle bulunmaktadır. Tekrar kayıt edilemez",
                    Success = false
                };
            jobTitle = _mapper.Map<Domain.Entities.JobTitle>(request);
            var result = await _jobTitleWriteRepository.AddAndSaveAsync(jobTitle);
            if(result == null)
                return new CreateJobTitleResponse()
                {
                    Message = "Dbye kayıt edilirken bir hata oluştu",
                    Success = false
                };

            return new CreateJobTitleResponse()
            {
                Message = $"{result.Id} id ile kayıt edildi.",
                Success = true
            };
        }
    }
}
