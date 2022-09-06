using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.BlogType.CreateBlogType;
using RealEstateWebApi.Application.Features.Commands.BlogType.UpdateBlogType;
using RealEstateWebApi.Application.Features.Queries.BlogType.GetAllBlogType;
using System.Data;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogTypeController : Controller
    {
        private IMediator _mediator;

        public BlogTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateBlogType(CreateBlogTypeRequest request)
        {
            CreateBlogTypeResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
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
