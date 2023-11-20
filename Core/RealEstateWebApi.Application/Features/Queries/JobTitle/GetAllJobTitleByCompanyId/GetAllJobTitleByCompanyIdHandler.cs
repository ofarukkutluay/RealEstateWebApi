using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.JobTitle.GetAllJobTitleByCompanyId
{
    public class GetAllJobTitleByCompanyIdHandler : IRequestHandler<GetAllJobTitleByCompanyIdRequest, GetAllJobTitleByCompanyIdResponse>
    {
        private readonly IJobTitleReadRepository _jobTitleReadRepository;

        public GetAllJobTitleByCompanyIdHandler(IJobTitleReadRepository jobTitleReadRepository)
        {
            _jobTitleReadRepository = jobTitleReadRepository;
        }

        public async Task<GetAllJobTitleByCompanyIdResponse> Handle(GetAllJobTitleByCompanyIdRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.JobTitle> jobTitles = _jobTitleReadRepository.GetWhere(e=>e.CompanyId == request.CompanyId);
            return await Task.FromResult( new GetAllJobTitleByCompanyIdResponse()
            {
                Data = jobTitles,
                Message = $"{jobTitles.Count()} adet data getirildi.",
                Success = true
            });
        }
    }
}
