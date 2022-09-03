using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.CustomerOwnedShortProperty.CreateCustomerOwnedShortProperty;
using RealEstateWebApi.Application.Features.Commands.CustomerOwnedShortProperty.DeleteCustomerOwnedShortProperty;
using RealEstateWebApi.Application.Features.Commands.CustomerOwnedShortProperty.UpdateCustomerOwnedShortProperty;
using RealEstateWebApi.Application.Features.Queries.CustomerOwnedShortProperty.GetAllCustomerOwnedShortPropertyByCustomerId;
using RealEstateWebApi.Application.Features.Queries.CustomerOwnedShortProperty.GetAllShortPropertyDtoByCustomerId;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerOwnedShortPropertyController : Controller
    {
        private readonly IMediator _mediator;

        public CustomerOwnedShortPropertyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomerOwnedShortProperty(CreateCustomerOwnedShortPropertyRequest request)
        {
            CreateCustomerOwnedShortPropertyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCustomerOwnedShortProperty(UpdateCustomerOwnedShortPropertyRequest request)
        {
            UpdateCustomerOwnedShortPropertyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCustomerOwnedShortProperty(DeleteCustomerOwnedShortPropertyRequest request)
        {
            DeleteCustomerOwnedShortPropertyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomerOwnedShortPropertyByCustomerId([FromQuery] GetAllCustomerOwnedShortPropertyByCustomerIdRequest request)
        {
            GetAllCustomerOwnedShortPropertyByCustomerIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("{CustomerId}")]
        public async Task<IActionResult> GetAllShortPropertyDtoByCustomerId([FromRoute] GetAllShortPropertyDtoByCustomerIdRequest request)
        {
            GetAllShortPropertyDtoByCustomerIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        
    }
}
