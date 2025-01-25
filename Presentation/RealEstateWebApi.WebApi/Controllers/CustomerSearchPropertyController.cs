using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.CustomerSearchProperty.CreateCustomerSearchProperty;
using RealEstateWebApi.Application.Features.Commands.CustomerSearchProperty.DeleteCustomerSearchProperty;
using RealEstateWebApi.Application.Features.Commands.CustomerSearchProperty.UpdateCustomerSearchProperty;
using RealEstateWebApi.Application.Features.Queries.CustomerSearchProperty.GetAllCustomerSearchPropertyByCustomerId;
using RealEstateWebApi.Application.Features.Queries.CustomerSearchProperty.GetAllCustomerSearchPropertyDtoByCustomerId;
using System.Data;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class CustomerSearchPropertyController : Controller
    {
        private readonly IMediator _mediator;

        public CustomerSearchPropertyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomerSearchShortProperty(CreateCustomerSearchPropertyRequest request)
        {
            CreateCustomerSearchPropertyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCustomerSearchShortProperty(UpdateCustomerSearchPropertyRequest request)
        {
            UpdateCustomerSearchPropertyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCustomerSearchShortProperty(DeleteCustomerSearchPropertyRequest request)
        {
            DeleteCustomerSearchPropertyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomerSearchShortPropertyByCustomerId([FromQuery] GetAllCustomerSearchPropertyByCustomerIdRequest request)
        {
            GetAllCustomerSearchPropertyByCustomerIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("{CustomerId}")]
        public async Task<IActionResult> GetAllShortPropertyDtoByCustomerId([FromRoute] GetAllCustomerSearchPropertyDtoByCustomerIdRequest request)
        {
            GetAllCustomerSearchPropertyDtoByCustomerIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }


    }
}
