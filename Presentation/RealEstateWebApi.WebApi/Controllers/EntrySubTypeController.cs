using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.EntrySubType.CreateEntrySubType;
using RealEstateWebApi.Application.Features.Commands.EntrySubType.DeleteEntrySubType;
using RealEstateWebApi.Application.Features.Commands.EntrySubType.UpdateEntrySubType;
using RealEstateWebApi.Application.Features.Queries.EntrySubType.GetAllEntrySubTypeByEntryTypeId;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntrySubTypeController : Controller
    {
        private readonly IMediator _mediator;

        public EntrySubTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEntrySubType(CreateEntrySubTypeRequest request)
        {
            CreateEntrySubTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateEntrySubType(UpdateEntrySubTypeRequest request)
        {
            UpdateEntrySubTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteEntrySubType(DeleteEntrySubTypeRequest request)
        {
            DeleteEntrySubTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEntrySubTypeByEntryTypeId([FromQuery] GetAllEntrySubTypeByEntryTypeIdRequest request)
        {
            GetAllEntrySubTypeByEntryTypeIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        
    }
}
