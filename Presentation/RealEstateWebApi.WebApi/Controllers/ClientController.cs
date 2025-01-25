using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.Client.CreateClient;
using RealEstateWebApi.Application.Features.Commands.Client.DeleteClient;
using RealEstateWebApi.Application.Features.Commands.Client.UpdateClient;
using RealEstateWebApi.Application.Features.Queries.Client.GetAllClient;
using System.Data;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Admin")]
    public class ClientController : Controller
    {
        private readonly IMediator _mediator;

        public ClientController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateClient(CreateClientRequest request)
        {
            CreateClientResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateClient(UpdateClientRequest request)
        {
            UpdateClientResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteClient(DeleteClientRequest request)
        {
            DeleteClientResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllClient()
        {
            var response = await _mediator.Send(new GetAllClientRequest());
            return Ok(response);
        }
    }
}
