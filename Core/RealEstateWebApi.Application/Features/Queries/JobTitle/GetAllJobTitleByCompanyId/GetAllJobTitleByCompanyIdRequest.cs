using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.JobTitle.GetAllJobTitleByCompanyId
{
    public class GetAllJobTitleByCompanyIdRequest : IRequest<GetAllJobTitleByCompanyIdResponse>
    {
        public uint CompanyId { get; set; }
    }
}
