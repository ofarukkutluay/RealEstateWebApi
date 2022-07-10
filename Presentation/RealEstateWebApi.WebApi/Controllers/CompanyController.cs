using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.Company.CreateCompany;
using RealEstateWebApi.Application.Features.Commands.Company.DeleteCompany;
using RealEstateWebApi.Application.Features.Commands.Company.UpdateCompany;
using RealEstateWebApi.Application.Features.Queries.Company.GetAllCompany;
using RealEstateWebApi.Application.Features.Queries.Company.GetCompanyById;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : Controller
    {
        private readonly IMediator _mediator;

        public CompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCompany(CreateCompanyRequest request)
        {
            CreateCompanyResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCompany(UpdateCompanyRequest request)
        {
            UpdateCompanyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCompany(DeleteCompanyRequest request)
        {
            DeleteCompanyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("{CompanyId}")]
        public async Task<IActionResult> GetCompanyById([FromRoute] GetCompanyByIdRequest request)
        {
            GetCompanyByIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCompany()
        {
            GetAllCompanyResponse response = await _mediator.Send(new GetAllCompanyRequest());
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
