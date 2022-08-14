using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.Entry.CreateEntry;
using RealEstateWebApi.Application.Features.Commands.Entry.DeleteEntry;
using RealEstateWebApi.Application.Features.Queries.Entry.GetAllEntryByCustomerId;
using RealEstateWebApi.Application.Features.Queries.Entry.GetAllEntryDtoByCustomerId;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntryController : Controller
    {
        private readonly IMediator _mediator;

        public EntryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEntry(CreateEntryRequest request)
        {
            CreateEntryResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEntry(DeleteEntryRequest request)
        {
            DeleteEntryResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        /* [HttpGet]
        public async Task<IActionResult> GetAllEntryByCustomerId([FromQuery] GetAllEntryByCustomerIdRequest request)
        {
            GetAllEntryByCustomerIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        } */

        [HttpGet]
        public async Task<IActionResult> GetAllEntryDtoByCustomerId([FromQuery] GetAllEntryDtoByCustomerIdRequest request)
        {
            GetAllEntryDtoByCustomerIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        
    }
}
