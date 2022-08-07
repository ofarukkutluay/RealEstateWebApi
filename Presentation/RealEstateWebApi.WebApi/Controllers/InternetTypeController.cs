using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.InternetType.CreateInternetType;
using RealEstateWebApi.Application.Features.Commands.InternetType.DeleteInternetType;
using RealEstateWebApi.Application.Features.Commands.InternetType.UpdateInternetType;
using RealEstateWebApi.Application.Features.Queries.InternetType.GetAllInternetType;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InternetTypeController : Controller
    {
        private readonly IMediator _mediator;

        public InternetTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateInternetType(CreateInternetTypeRequest request)
        {
            CreateInternetTypeResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateInternetType(UpdateInternetTypeRequest request)
        {
            UpdateInternetTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteInternetType(DeleteInternetTypeRequest request)
        {
            DeleteInternetTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllInternetType()
        {
            GetAllInternetTypeResponse response = await _mediator.Send(new GetAllInternetTypeRequest());
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
