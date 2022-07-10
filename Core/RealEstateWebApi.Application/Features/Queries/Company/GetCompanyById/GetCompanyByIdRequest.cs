using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Company.GetCompanyById
{
    public class GetCompanyByIdRequest : IRequest<GetCompanyByIdResponse>
    {
        public uint CompanyId { get; set; }
    }
}
