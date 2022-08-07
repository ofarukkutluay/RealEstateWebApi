using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Queries.OperationClaim.GetAllOperationClaim;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperationClaimController : Controller
    {
        private readonly IMediator _mediator;

        public OperationClaimController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOperationClaim()
        {
            GetAllOperationClaimResponse response = await _mediator.Send(new GetAllOperationClaimRequest());
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
