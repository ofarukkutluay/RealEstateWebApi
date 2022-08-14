using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.Customer.CreateCustomer;
using RealEstateWebApi.Application.Features.Commands.Customer.DeleteCustomer;
using RealEstateWebApi.Application.Features.Commands.Customer.UpdateCustomer;
using RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomer;
using RealEstateWebApi.Application.Features.Queries.Customer.GetAllCustomerDto;
using RealEstateWebApi.Application.Features.Queries.Customer.GetCustomerById;
using RealEstateWebApi.Application.Features.Queries.Customer.GetCustomerDtoById;

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
        public async Task<IActionResult> CreateCustomer(CreateCustomerRequest request)
        {
            CreateCustomerResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerRequest request)
        {
            UpdateCustomerResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCustomer(DeleteCustomerRequest request)
        {
            DeleteCustomerResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        /* [HttpGet("{Id}")]
        public async Task<IActionResult> GetCustomerById([FromRoute] GetCustomerByIdRequest request)
        {
            GetCustomerByIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        } */

        /* [HttpGet]
        public async Task<IActionResult> GetAllCustomer()
        {
            GetAllCustomerResponse response = await _mediator.Send(new GetAllCustomerRequest());
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        } */

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetCustomerDtoById([FromRoute] GetCustomerDtoByIdRequest request)
        {
            GetCustomerDtoByIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCustomerDto()
        {
            GetAllCustomerDtoResponse response = await _mediator.Send(new GetAllCustomerDtoRequest());
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
