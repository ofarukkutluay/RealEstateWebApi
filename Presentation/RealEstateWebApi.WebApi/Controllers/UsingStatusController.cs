using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.UsingStatus.CreateUsingStatus;
using RealEstateWebApi.Application.Features.Commands.UsingStatus.DeleteUsingStatus;
using RealEstateWebApi.Application.Features.Commands.UsingStatus.UpdateUsingStatus;
using RealEstateWebApi.Application.Features.Queries.UsingStatus.GetAllUsingStatus;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsingStatusController : Controller
    {
        private readonly IMediator _mediator;

        public UsingStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUsingStatus(CreateUsingStatusRequest request)
        {
            CreateUsingStatusResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUsingStatus(UpdateUsingStatusRequest request)
        {
            UpdateUsingStatusResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUsingStatus(DeleteUsingStatusRequest request)
        {
            DeleteUsingStatusResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsingStatus()
        {
            GetAllUsingStatusResponse response = await _mediator.Send(new GetAllUsingStatusRequest());
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
