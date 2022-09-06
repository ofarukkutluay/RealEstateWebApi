using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.EntrySubType.CreateEntrySubType;
using RealEstateWebApi.Application.Features.Commands.EntrySubType.DeleteEntrySubType;
using RealEstateWebApi.Application.Features.Commands.EntrySubType.UpdateEntrySubType;
using RealEstateWebApi.Application.Features.Queries.EntrySubType.GetAllEntrySubTypeByEntryTypeId;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntrySubTypeController : Controller
    {
        private readonly IMediator _mediator;

        public EntrySubTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateEntrySubType(CreateEntrySubTypeRequest request)
        {
            CreateEntrySubTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateEntrySubType(UpdateEntrySubTypeRequest request)
        {
            UpdateEntrySubTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
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
