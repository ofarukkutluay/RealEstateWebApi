using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.UserLogin.DeleteUserlogin;
using RealEstateWebApi.Application.Features.Queries.UserLogin.GetAllUserLogin;
using RealEstateWebApi.Application.Features.Queries.UserLogin.GetAllUserLoginByUserId;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize(Roles = "Admin")]
    public class UserLoginController : Controller
    {
        private readonly IMediator _mediator;

        public UserLoginController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUserLogin()
        {
            GetAllUserLoginResponse response = await _mediator.Send(new GetAllUserLoginRequest());
            if(response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("{UserId}")]
        public async Task<IActionResult> GetAllUserLoginByUserId([FromRoute] GetAllUserLoginByUserIdRequest request)
        {
            GetAllUserLoginByUserIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUserLogin(DeleteUserLoginRequest request)
        {
            DeleteUserLoginResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
