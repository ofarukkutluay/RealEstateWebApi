using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.Company.CreateCompany;
using RealEstateWebApi.Application.Features.Queries.Company.GetAllCompany;

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

        [HttpGet]
        public async Task<IActionResult> GetAllCompany([FromQuery] GetAllCompanyRequest request)
        {
            GetAllCompanyResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
