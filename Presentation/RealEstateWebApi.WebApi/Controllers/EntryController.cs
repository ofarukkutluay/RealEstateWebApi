using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.Entry.CreateEntry;
using RealEstateWebApi.Application.Features.Commands.Entry.DeleteEntry;
using RealEstateWebApi.Application.Features.Queries.Entry.GetAllEntryByCustomerId;
using RealEstateWebApi.Application.Features.Queries.Entry.GetAllEntryDtoByCustomerId;
using RealEstateWebApi.Application.Features.Queries.Entry.GetCountEntryByUserId;

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
        [Authorize]
        public async Task<IActionResult> CreateEntry(CreateEntryRequest request)
        {
            CreateEntryResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteEntry(DeleteEntryRequest request)
        {
            DeleteEntryResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("count")]
        [Authorize]
        public async Task<IActionResult> GetCountEntryByUserId([FromQuery] GetCountEntryByUserIdRequest request)
        {
            GetCountEntryByUserIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllEntryDtoByCustomerId([FromQuery] GetAllEntryDtoByCustomerIdRequest request)
        {
            GetAllEntryDtoByCustomerIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }


        
    }
}
