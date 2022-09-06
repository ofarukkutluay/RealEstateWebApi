using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.ShortProperty.CreateShortProperty;
using RealEstateWebApi.Application.Features.Commands.ShortProperty.DeleteShortProperty;
using RealEstateWebApi.Application.Features.Commands.ShortProperty.UpdateShortProperty;
using RealEstateWebApi.Application.Features.Queries.ShortProperty.GetAllShortProperty;
using System.Data;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ShortPropertyController : Controller
    {
        private readonly IMediator _mediator;

        public ShortPropertyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateShortProperty(CreateShortPropertyRequest request)
        {
            CreateShortPropertyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateShortProperty(UpdateShortPropertyRequest request)
        {
            UpdateShortPropertyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteShortProperty(DeleteShortPropertyRequest request)
        {
            DeleteShortPropertyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllShortProperty()
        {
            GetAllShortPropertyResponse response = await _mediator.Send(new GetAllShortPropertyRequest());
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
