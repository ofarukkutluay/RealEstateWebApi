using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.Blog.CreateBlog;
using RealEstateWebApi.Application.Features.Commands.Blog.DeleteBlog;
using RealEstateWebApi.Application.Features.Commands.Blog.UpdateBlog;
using RealEstateWebApi.Application.Features.Commands.Blog.UploadBlogPageImgFile;
using RealEstateWebApi.Application.Features.Queries.Blog.GetAllBlogByClientId;
using RealEstateWebApi.Application.Features.Queries.Blog.GetBlogById;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlogController : Controller
    {
        private IMediator _mediator;

        public BlogController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateBlog([FromBody] CreateBlogRequest request)
        {
            CreateBlogResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> UploadBlogImage(UploadBlogPageImgFileRequest request)
        {
            UploadBlogPageImgFileResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogRequest request)
        {
            UpdateBlogResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteBlog(DeleteBlogRequest request)
        {
            DeleteBlogResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlogByClientId([FromQuery] GetAllBlogByClientIdRequest request)
        {
            GetAllBlogByClientIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("{BlogId}")]
        public async Task<IActionResult> GetBlogById([FromRoute] GetBlogByIdRequest request)
        {
            GetBlogByIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }


    }
}
