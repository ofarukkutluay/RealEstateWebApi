using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.PropertyStatus.CreatePropertyStatus;
using RealEstateWebApi.Application.Features.Commands.PropertyStatus.DeletePropertyStatus;
using RealEstateWebApi.Application.Features.Commands.PropertyStatus.UpdatePropertyStatus;
using RealEstateWebApi.Application.Features.Queries.PropertyStatus.GetAllPropertyStatus;
using System.Data;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyStatusController : Controller
    {
        private readonly IMediator _mediator;

        public PropertyStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreatePropertyStatus(CreatePropertyStatusRequest request)
        {
            CreatePropertyStatusResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdatePropertyStatus(UpdatePropertyStatusRequest request)
        {
            UpdatePropertyStatusResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeletePropertyStatus(DeletePropertyStatusRequest request)
        {
            DeletePropertyStatusResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPropertyStatus([FromQuery] GetAllPropertyStatusRequest request)
        {
            GetAllPropertyStatusResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
