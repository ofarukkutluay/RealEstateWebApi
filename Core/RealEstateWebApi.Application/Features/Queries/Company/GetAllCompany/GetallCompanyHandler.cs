using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Company.GetAllCompany
{
    public class GetallCompanyHandler : IRequestHandler<GetAllCompanyRequest, GetAllCompanyResponse>
    {
        private readonly ICompanyReadRepository _companyReadRepository;

        public GetallCompanyHandler(ICompanyReadRepository companyReadRepository)
        {
            _companyReadRepository = companyReadRepository;
        }

        public async Task<GetAllCompanyResponse> Handle(GetAllCompanyRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.Company> companies = _companyReadRepository.GetAll();
            return await Task.FromResult(new GetAllCompanyResponse()
            {
                Data = companies,
                Message = "Tüm company datası getirildi.",
                Success = true
            });
        }
    }
}
