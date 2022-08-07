using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.UserOperationClaim.CreateUserOperationClaim;
using RealEstateWebApi.Application.Features.Commands.UserOperationClaim.DeleteUserOperationClaim;
using RealEstateWebApi.Application.Features.Queries.UserOperationClaim.GetAllUserOperationClaimByOperationClaimId;
using RealEstateWebApi.Application.Features.Queries.UserOperationClaim.GetAllUserOperationClaimByUserId;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserOperationClaimController : Controller
    {
        private readonly IMediator _mediator;

        public UserOperationClaimController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{UserId}")]
        public async Task<IActionResult> GetAllUserOperationClaimByUserId([FromRoute] GetAllUserOperationClaimByUserIdRequest request)
        {
            GetAllUserOperationClaimByUserIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);

        }

        [HttpGet]
        public async Task<IActionResult> GetAllUserOperationClaimByOperationClaimId([FromQuery] GetAllUserOperationClaimByOperationClaimIdRequest request)
        {
            GetAllUserOperationClaimByOperationClaimIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);

        }

        [HttpPost]
        public async Task<IActionResult> CreateUserOperationClaim( CreateUserOperationClaimRequest request)
        {
            CreateUserOperationClaimResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);

        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUserOperationClaim(DeleteUserOperationClaimRequest request)
        {
            DeleteUserOperationClaimResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);

        }
    }
}
