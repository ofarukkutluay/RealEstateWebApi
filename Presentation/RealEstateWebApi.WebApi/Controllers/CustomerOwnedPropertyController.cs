using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.CustomerOwnedProperty.CreateCustomerOwnedProperty;
using RealEstateWebApi.Application.Features.Commands.CustomerOwnedProperty.DeleteCustomerOwnedProperty;
using RealEstateWebApi.Application.Features.Commands.CustomerOwnedProperty.UpdateCustomerOwnedProperty;
using RealEstateWebApi.Application.Features.Queries.CustomerOwnedProperty.GetAllCustomerOwnedPropertyByCustomerId;
using RealEstateWebApi.Application.Features.Queries.CustomerOwnedProperty.GetAllCustomerOwnedPropertyDto;
using RealEstateWebApi.Application.Features.Queries.CustomerOwnedProperty.GetAllCustomerOwnedPropertyDtoByCustomerId;
using System.Data;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class CustomerOwnedPropertyController : Controller
    {
        private readonly IMediator _mediator;

        public CustomerOwnedPropertyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomerOwnedProperty(CreateCustomerOwnedPropertyRequest request)
        {
            CreateCustomerOwnedPropertyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCustomerOwnedProperty(UpdateCustomerOwnedPropertyRequest request)
        {
            UpdateCustomerOwnedPropertyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCustomerOwnedProperty(DeleteCustomerOwnedPropertyRequest request)
        {
            DeleteCustomerOwnedPropertyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomerOwnedPropertyDto([FromQuery] GetAllCustomerOwnedPropertyDtoRequest request)
        {
            GetAllCustomerOwnedPropertyDtoResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAllCustomerOwnedPropertyByCustomerId([FromQuery] GetAllCustomerOwnedPropertyByCustomerIdRequest request)
        //{
        //    GetAllCustomerOwnedPropertyByCustomerIdResponse response = await _mediator.Send(request);
        //    if (response.Success)
        //        return Ok(response);
        //    return BadRequest(response);
        //}

        [HttpGet("{CustomerId}")]
        public async Task<IActionResult> GetAllCustomerOwnedPropertyDtoByCustomerId([FromRoute] GetAllCustomerOwnedPropertyDtoByCustomerIdRequest request)
        {
            GetAllCustomerOwnedPropertyDtoByCustomerIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        
    }
}
