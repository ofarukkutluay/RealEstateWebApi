using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.User.LoginUser;
using RealEstateWebApi.Application.Features.Commands.User.LogoutUser;
using RealEstateWebApi.Application.Features.Commands.User.RegisterUser;
using RealEstateWebApi.Application.Features.Queries.User.GetAllUser;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> AllUser([FromQuery] GetAllUserRequest request)
        {
            GetAllUserResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Register(RegisterUserRequest request)
        {
            RegisterUserResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(LoginUserRequest request)
        {
            LoginUserResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Logout(LogoutUserRequest request)
        {
            LogoutUserResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
