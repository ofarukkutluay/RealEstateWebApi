using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Company.DeleteCompany
{
    public class DeleteCompanyRequest : IRequest<DeleteCompanyResponse>
    {
        public uint CompanyId { get; set; }
    }
}
