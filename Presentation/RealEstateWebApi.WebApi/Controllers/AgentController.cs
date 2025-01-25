using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.Agent.CreateAgent;
using RealEstateWebApi.Application.Features.Commands.Agent.DeleteAgent;
using RealEstateWebApi.Application.Features.Commands.Agent.UpdateAgent;
using RealEstateWebApi.Application.Features.Queries.Agent.GetAgentByUserId;
using RealEstateWebApi.Application.Features.Queries.Agent.GetAllAgentByCompanyId;
using System.Data;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AgentController : Controller
    {
        private readonly IMediator _mediator;

        public AgentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllAgentByCompanyId([FromQuery] GetAllAgentByCompanyIdRequest request)
        {
            GetAllAgentByCompanyIdResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("{UserId}")]
        [Authorize]
        public async Task<IActionResult> GetAgentByUserId([FromRoute] GetAgentByUserIdRequest request)
        {
            GetAgentByUserIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateAgent(CreateAgentRequest request)
        {
            CreateAgentResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateAgent(UpdateAgentRequest request)
        {
            UpdateAgentResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteAgent(DeleteAgentRequest request)
        {
            DeleteAgentResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
