using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.DeedStatus.CreateDeedStatus;
using RealEstateWebApi.Application.Features.Commands.DeedStatus.DeleteDeedStatus;
using RealEstateWebApi.Application.Features.Commands.DeedStatus.UpdateDeedStatus;
using RealEstateWebApi.Application.Features.Queries.DeedStatus.GetAllDeedStatus;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeedStatusController : Controller
    {
        private readonly IMediator _mediator;

        public DeedStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateDeedStatus(CreateDeedStatusRequest request)
        {
            CreateDeedStatusResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDeedStatus(UpdateDeedStatusRequest request)
        {
            UpdateDeedStatusResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteDeedStatus(DeleteDeedStatusRequest request)
        {
            DeleteDeedStatusResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllDeedStatus()
        {
            GetAllDeedStatusResponse response = await _mediator.Send(new GetAllDeedStatusRequest());
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
