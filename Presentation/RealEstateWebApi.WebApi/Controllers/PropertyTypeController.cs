using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.PropertyType.CreatePropertyType;
using RealEstateWebApi.Application.Features.Commands.PropertyType.DeletePropertyType;
using RealEstateWebApi.Application.Features.Commands.PropertyType.UpdatePropertyType;
using RealEstateWebApi.Application.Features.Queries.PropertyType.GetAllPropertyType;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropertyTypeController : Controller
    {
        private readonly IMediator _mediator;

        public PropertyTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePropertyType(CreatePropertyTypeRequest request)
        {
            CreatePropertyTypeResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePropertyType(UpdatePropertyTypeRequest request)
        {
            UpdatePropertyTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePropertyType(DeletePropertyTypeRequest request)
        {
            DeletePropertyTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPropertyType()
        {
            GetAllPropertyTypeResponse response = await _mediator.Send(new GetAllPropertyTypeRequest());
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
