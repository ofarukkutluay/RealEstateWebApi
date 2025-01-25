using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Company.UpdateCompany
{
    public class UpdateCompanyHandler : IRequestHandler<UpdateCompanyRequest, UpdateCompanyResponse>
    {
        private readonly ICompanyReadRepository _companyReadRepository;
        private readonly ICompanyWriteRepository _companyWriteRepository;

        public UpdateCompanyHandler(ICompanyReadRepository companyReadRepository, ICompanyWriteRepository companyWriteRepository)
        {
            _companyReadRepository = companyReadRepository;
            _companyWriteRepository = companyWriteRepository;
        }

        public async Task<UpdateCompanyResponse> Handle(UpdateCompanyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Company company = await _companyReadRepository.GetByIdAsync(request.CompanyId);
            if(company == null)
                return new UpdateCompanyResponse()
                {
                    Message = "Company bulunamadı",
                    Success = false
                };

            company.CompanyName = request.CompanyName == default ? company.CompanyName : request.CompanyName;
            company.TaxNumber = request.TaxNumber == default ? company.TaxNumber : request.TaxNumber;
            company.Address = request.Address == default ? company.Address : request.Address;
            company.IsActive = request.IsActive;
            company.StartingYear = request.StartingYear == default ? company.StartingYear : request.StartingYear;
            company.TaxAdministration = request.TaxAdministration == default ? company.TaxAdministration : request.TaxAdministration;
            var result = await _companyWriteRepository.SaveAsync();
            if(result<=0)
                return new UpdateCompanyResponse()
                {
                    Message ="Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };

            return new UpdateCompanyResponse()
            {
                Message = "Company güncellendi",
                Success =true
            };
        }
    }
}
