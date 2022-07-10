using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.Front.CreateFront;
using RealEstateWebApi.Application.Features.Commands.Front.DeleteFront;
using RealEstateWebApi.Application.Features.Commands.Front.UpdateFront;
using RealEstateWebApi.Application.Features.Queries.Front.GetAllFront;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FrontController : Controller
    {
        private readonly IMediator _mediator;

        public FrontController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateFront(CreateFrontRequest request)
        {
            CreateFrontResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFront(UpdateFrontRequest request)
        {
            UpdateFrontResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFront(DeleteFrontRequest request)
        {
            DeleteFrontResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllFront()
        {
            GetAllFrontResponse response = await _mediator.Send(new GetAllFrontRequest());
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
