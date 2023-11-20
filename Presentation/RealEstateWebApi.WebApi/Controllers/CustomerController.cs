using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.Customer.ChangeActivateCustomer;
using RealEstateWebApi.Application.Features.Commands.Customer.CreateCustomer;
using RealEstateWebApi.Application.Features.Commands.Customer.DeleteCustomer;
using RealEstateWebApi.Application.Features.Commands.Customer.UpdateCustomer;
using RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomer;
using RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomerCount;
using RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomerDto;
using RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomerDtoByStatusKey;
using RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomerDtoByWhere;
using RealEstateWebApi.Application.Features.Queries.Customer.GetCustomerById;
using RealEstateWebApi.Application.Features.Queries.Customer.GetCustomerDtoById;
using RealEstateWebApi.Application.Features.Queries.Customer.GetRecentCustomerDtoList;
using System.Data;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> CreateCustomer(CreateCustomerRequest request)
        {
            CreateCustomerResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerRequest request)
        {
            UpdateCustomerResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut("[action]")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ChangeActivate(ChangeActivateCustomerRequest request)
        {
            ChangeActivateCustomerResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteCustomer(DeleteCustomerRequest request)
        {
            DeleteCustomerResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetCustomerById([FromRoute] GetCustomerByIdRequest request)
        {
            GetCustomerByIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        /* [HttpGet]
        public async Task<IActionResult> GetAllCustomer()
        {
            GetAllCustomerResponse response = await _mediator.Send(new GetAllCustomerRequest());
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        } */

        [HttpGet("dto/{Id}")]
        [Authorize]
        public async Task<IActionResult> GetCustomerDtoById([FromRoute] GetCustomerDtoByIdRequest request)
        {
            GetCustomerDtoByIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllCustomerDto([FromQuery] GetAllCustomerDtoRequest request)
        {
            GetAllCustomerDtoResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        //[HttpGet("search")]
        //[Authorize]
        //public async Task<IActionResult> GetAllCustomerDtoByWhere([FromQuery] GetAllCustomerDtoByWhereRequest request)
        //{
        //    GetAllCustomerDtoByWhereResponse response = await _mediator.Send(request);
        //    if (response.Success)
        //        return Ok(response);
        //    return BadRequest(response);
        //}

        [HttpGet("recent")]
        [Authorize]
        public async Task<IActionResult> GetRecentCustomerDtoList([FromQuery] GetRecentCustomerDtoListRequest request)
        {
            GetRecentCustomerDtoListResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("status")]
        [Authorize]
        public async Task<IActionResult> GetAllCustomerDtoByStatusKey([FromQuery] GetAllCustomerDtoByStatusKeyRequest request)
        {
            GetAllCustomerDtoByStatusKeyResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("count")]
        [Authorize]
        public async Task<IActionResult> GetAllCustomerCount()
        {
            GetAllCustomerCountResponse response = await _mediator.Send(new GetAllcustomerCountRequest());
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
