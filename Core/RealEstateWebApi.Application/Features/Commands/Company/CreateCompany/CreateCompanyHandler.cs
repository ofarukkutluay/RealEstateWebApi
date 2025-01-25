using AutoMapper;
using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Company.CreateCompany
{
    public class CreateCompanyHandler : IRequestHandler<CreateCompanyRequest, CreateCompanyResponse>
    {
        private readonly ICompanyReadRepository _companyReadRepository;
        private readonly ICompanyWriteRepository _companyWriteRepository;
        private readonly IMapper _mapper;

        public CreateCompanyHandler(ICompanyReadRepository companyReadRepository, ICompanyWriteRepository companyWriteRepository, IMapper mapper)
        {
            _companyReadRepository = companyReadRepository;
            _companyWriteRepository = companyWriteRepository;
            _mapper = mapper;
        }

        public async Task<CreateCompanyResponse> Handle(CreateCompanyRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Company company = await _companyReadRepository.GetSingleAsync(e=>e.TaxNumber == request.TaxNumber);
            if(company is not null)
                return new CreateCompanyResponse()
                {
                    Message = "Bu vergi numarasında bir kayıt bulunmaktadır",
                    Success = false
                };
            company = _mapper.Map<Domain.Entities.Company>(request);
            var result = await _companyWriteRepository.AddAndSaveAsync(company);
            if(result is null)
                return new CreateCompanyResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new CreateCompanyResponse()
            {
                Message = $"{result.Id} id ile kayıt edildi",
                Success = true
            };
        }
    }
}
