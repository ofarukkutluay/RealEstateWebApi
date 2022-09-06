using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.CustomerSearchShortProperty.CreateCustomerSearchShortProperty;
using RealEstateWebApi.Application.Features.Commands.CustomerSearchShortProperty.DeleteCustomerSearchShortProperty;
using RealEstateWebApi.Application.Features.Commands.CustomerSearchShortProperty.UpdateCustomerSearchShortProperty;
using RealEstateWebApi.Application.Features.Queries.CustomerSearchShortProperty.GetAllCustomerSearchShortPropertyByCustomerId;
using RealEstateWebApi.Application.Features.Queries.CustomerSearchShortProperty.GetAllShortPropertyDtoByCustomerId;
using System.Data;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class CustomerSearchShortPropertyController : Controller
    {
        private readonly IMediator _mediator;

        public CustomerSearchShortPropertyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomerSearchShortProperty(CreateCustomerSearchShortPropertyRequest request)
        {
            CreateCustomerSearchShortPropertyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCustomerSearchShortProperty(UpdateCustomerSearchShortPropertyRequest request)
        {
            UpdateCustomerSearchShortPropertyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCustomerSearchShortProperty(DeleteCustomerSearchShortPropertyRequest request)
        {
            DeleteCustomerSearchShortPropertyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomerSearchShortPropertyByCustomerId([FromQuery] GetAllCustomerSearchShortPropertyByCustomerIdRequest request)
        {
            GetAllCustomerSearchShortPropertyByCustomerIdResponse response = await _mediator.Send(request);
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
