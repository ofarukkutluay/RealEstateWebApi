using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.JobTitle.CreateJobTitle;
using RealEstateWebApi.Application.Features.Commands.JobTitle.DeleteJobTitle;
using RealEstateWebApi.Application.Features.Commands.JobTitle.UpdateJobTitle;
using RealEstateWebApi.Application.Features.Queries.JobTitle.GetAllJobTitleByCompanyId;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobTitleController : Controller
    {
        private readonly IMediator _mediator;

        public JobTitleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateJobTitle(CreateJobTitleRequest request)
        {
            CreateJobTitleResponse response = await _mediator.Send(request);
            if(response.Success)
                Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteJobTitle(DeleteJobTitleRequest request)
        {
            DeleteJobTitleResponse response = await _mediator.Send(request);
            if (response.Success)
                Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateJobTitle(UpdateJobTitleRequest request)
        {
            UpdateJobTitleResponse response = await _mediator.Send(request);
            if (response.Success)
                Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllJobTitleByCompanyId([FromQuery] GetAllJobTitleByCompanyIdRequest request)
        {
            GetAllJobTitleByCompanyIdResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
