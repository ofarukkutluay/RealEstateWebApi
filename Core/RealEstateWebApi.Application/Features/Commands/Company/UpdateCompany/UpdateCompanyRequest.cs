using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Company.UpdateCompany
{
    public class UpdateCompanyRequest : IRequest<UpdateCompanyResponse>
    {
        public uint CompanyId { get; set; }
        public string CompanyName { get; set; }
        public uint TaxNumber { get; set; }
        public string TaxAdministration { get; set; }
        public ushort StartingYear { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
    }
}
