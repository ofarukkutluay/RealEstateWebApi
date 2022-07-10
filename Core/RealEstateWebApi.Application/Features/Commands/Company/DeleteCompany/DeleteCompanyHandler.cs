using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Company.DeleteCompany
{
    public class DeleteCompanyHandler : IRequestHandler<DeleteCompanyRequest, DeleteCompanyResponse>
    {
        private readonly ICompanyReadRepository _companyReadRepository;
        private readonly ICompanyWriteRepository _companyWriteRepository;
        public DeleteCompanyHandler(ICompanyReadRepository companyReadRepository, ICompanyWriteRepository companyWriteRepository)
        {
            _companyReadRepository = companyReadRepository;
            _companyWriteRepository = companyWriteRepository;
        }

        public async Task<DeleteCompanyResponse> Handle(DeleteCompanyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Company company = await _companyReadRepository.GetByIdAsync(request.CompanyId);
            if(company == null)
                return new DeleteCompanyResponse()
                {
                    Message = "Company bulunamadı",
                    Success = false
                };
            await _companyWriteRepository.RemoveAsync(request.CompanyId);
            var result = await _companyWriteRepository.SaveAsync();
            if(result<=0)
                return new DeleteCompanyResponse()
                {
                    Message = "Db ye kayıtedilirken bir hata oluştu",
                    Success = false
                };

            return new DeleteCompanyResponse()
            {
                Message = "Company silindi",
                Success = true
            };
        }
    }
}
