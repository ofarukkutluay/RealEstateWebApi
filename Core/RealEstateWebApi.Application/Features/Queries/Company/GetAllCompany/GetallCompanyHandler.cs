﻿using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Queries.Company.GetAllCompany
{
    public class GetAllCompanyHandler : IRequestHandler<GetAllCompanyRequest, GetAllCompanyResponse>
    {
        private readonly ICompanyReadRepository _companyReadRepository;

        public GetAllCompanyHandler(ICompanyReadRepository companyReadRepository)
        {
            _companyReadRepository = companyReadRepository;
        }

        public async Task<GetAllCompanyResponse> Handle(GetAllCompanyRequest request, CancellationToken cancellationToken)
        {
            IEnumerable<Domain.Entities.Company> companies = _companyReadRepository.GetWhere(x => x.IsDeleted == false);
            return await Task.FromResult(new GetAllCompanyResponse()
            {
                Data = companies,
                Message = "Tüm company datası getirildi.",
                Success = true
            });
        }
    }
}
