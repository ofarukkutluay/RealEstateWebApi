using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.HeatingType.CreateHeatingType;
using RealEstateWebApi.Application.Features.Commands.HeatingType.DeleteHeatingType;
using RealEstateWebApi.Application.Features.Commands.HeatingType.UpdateHeatingType;
using RealEstateWebApi.Application.Features.Queries.HeatingType.GetAllHeatingType;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeatingTypeController : Controller
    {
        private readonly IMediator _mediator;

        public HeatingTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateHeatingType(CreateHeatingTypeRequest request)
        {
            CreateHeatingTypeResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateHeatingType(UpdateHeatingTypeRequest request)
        {
            UpdateHeatingTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteHeatingType(DeleteHeatingTypeRequest request)
        {
            DeleteHeatingTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHeatingType()
        {
            GetAllHeatingTypeResponse response = await _mediator.Send(new GetAllHeatingTypeRequest());
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
