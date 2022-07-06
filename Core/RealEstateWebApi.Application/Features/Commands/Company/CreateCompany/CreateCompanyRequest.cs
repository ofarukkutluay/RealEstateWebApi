using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Company.CreateCompany
{
    public class CreateCompanyRequest : IRequest<CreateCompanyResponse>
    {
        public string CompanyName { get; set; }
        public uint TaxNumber { get; set; }
        public string TaxAdministration { get; set; }
        public ushort StartingYear { get; set; }
        public string Address { get; set; }
    }
}
