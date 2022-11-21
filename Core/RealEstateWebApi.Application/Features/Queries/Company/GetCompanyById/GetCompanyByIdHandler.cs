using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Company.GetCompanyById
{
    public class GetCompanyByIdHandler : IRequestHandler<GetCompanyByIdRequest, GetCompanyByIdResponse>
    {
        private readonly ICompanyReadRepository _companyReadRepository;

        public GetCompanyByIdHandler(ICompanyReadRepository companyReadRepository)
        {
            _companyReadRepository = companyReadRepository;
        }

        public async Task<GetCompanyByIdResponse> Handle(GetCompanyByIdRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Company company = await _companyReadRepository.GetByIdAsync(request.CompanyId);
            if(company.IsDeleted)
                return new GetCompanyByIdResponse()
                {
                    Message = "data silinmiş",
                    Success = false,
                    Data = null
                };
            return new GetCompanyByIdResponse()
            {
                Message = "Company getirildi",
                Data = company,
                Success = true
            };
        }
    }
}
