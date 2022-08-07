using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.EntryType.CreateEntryType;
using RealEstateWebApi.Application.Features.Commands.EntryType.DeleteEntryType;
using RealEstateWebApi.Application.Features.Commands.EntryType.UpdateEntryType;
using RealEstateWebApi.Application.Features.Queries.EntryType.GetAllEntryType;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntryTypeController : Controller
    {
        private readonly IMediator _mediator;

        public EntryTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEntryType(CreateEntryTypeRequest request)
        {
            CreateEntryTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEntryType(UpdateEntryTypeRequest request)
        {
            UpdateEntryTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEntryType(DeleteEntryTypeRequest request)
        {
            DeleteEntryTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEntryType()
        {
            GetAllEntryTypeResponse response = await _mediator.Send(new GetAllEntryTypeRequest());
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        
    }
}
