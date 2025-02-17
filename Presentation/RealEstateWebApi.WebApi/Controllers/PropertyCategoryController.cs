using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.PropertyCategory.CreatePropertyCategory;
using RealEstateWebApi.Application.Features.Commands.PropertyCategory.DeletePropertyCategory;
using RealEstateWebApi.Application.Features.Commands.PropertyCategory.UpdatePropertyCategory;
using RealEstateWebApi.Application.Features.Queries.PropertyCategory.GetAllPropertyCategory;
using System.Data;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyCategoryController : Controller
    {
        private readonly IMediator _mediator;

        public PropertyCategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreatePropertyCategory(CreatePropertyCategoryRequest request)
        {
            CreatePropertyCategoryResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdatePropertyCategory(UpdatePropertyCategoryRequest request)
        {
            UpdatePropertyCategoryResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeletePropertyCategory(DeletePropertyCategoryRequest request)
        {
            DeletePropertyCategoryResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPropertyCategory()
        {
            GetAllPropertyCategoryResponse response = await _mediator.Send(new GetAllPropertyCategoryRequest());
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
