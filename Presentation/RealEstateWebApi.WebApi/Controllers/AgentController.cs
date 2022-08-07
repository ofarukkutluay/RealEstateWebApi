using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.Agent.CreateAgent;
using RealEstateWebApi.Application.Features.Commands.Agent.DeleteAgent;
using RealEstateWebApi.Application.Features.Commands.Agent.UpdateAgent;
using RealEstateWebApi.Application.Features.Queries.Agent.GetAgentByUserId;
using RealEstateWebApi.Application.Features.Queries.Agent.GetAllAgentByCompanyId;

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
        public async Task<IActionResult> GetAllAgentByCompanyId([FromQuery] GetAllAgentByCompanyIdRequest request)
        {
            GetAllAgentByCompanyIdResponse response = await _mediator.Send(request);
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("{UserId}")]
        public async Task<IActionResult> GetAgentByUserId([FromRoute] GetAgentByUserIdRequest request)
        {
            GetAgentByUserIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAgent(CreateAgentRequest request)
        {
            CreateAgentResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAgent(UpdateAgentRequest request)
        {
            UpdateAgentResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAgent(DeleteAgentRequest request)
        {
            DeleteAgentResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
