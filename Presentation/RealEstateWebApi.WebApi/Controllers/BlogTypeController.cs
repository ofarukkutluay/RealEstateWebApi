using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.BlogType.CreateBlogType;
using RealEstateWebApi.Application.Features.Commands.BlogType.UpdateBlogType;
using RealEstateWebApi.Application.Features.Queries.BlogType.GetAllBlogType;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogTypeController : Controller
    {
        private IMediator _mediator;

        public BlogTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlogType(CreateBlogTypeRequest request)
        {
            CreateBlogTypeResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlogType(UpdateBlogTypeRequest request)
        {
            UpdateBlogTypeResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlogType()
        {
            GetAllBlogTypeResponse response = await _mediator.Send(new GetAllBlogTypeRequest());
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
