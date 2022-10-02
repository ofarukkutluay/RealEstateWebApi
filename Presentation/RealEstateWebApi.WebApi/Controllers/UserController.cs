using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.User.ChangePasswordUser;
using RealEstateWebApi.Application.Features.Commands.User.LoginUser;
using RealEstateWebApi.Application.Features.Commands.User.LogoutUser;
using RealEstateWebApi.Application.Features.Commands.User.RegisterUser;
using RealEstateWebApi.Application.Features.Commands.User.UpdateUser;
using RealEstateWebApi.Application.Features.Commands.User.UploadProfilePhotoUser;
using RealEstateWebApi.Application.Features.Queries.User.GetAllUser;
using RealEstateWebApi.Application.Features.Queries.User.GetUserByUserId;

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
        [Authorize(Roles = "Admin")]
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

        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> ChangePassword(ChangePasswordUserRequest request)
        {
            ChangePasswordUserResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPost("[action]")]
        [Authorize]
        public async Task<IActionResult> UploadPhoto([FromForm] UploadProfilePhotoUserRequest request)
        {
            UploadProfilePhotoUserResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        [Authorize]
        public async Task<IActionResult> Update(UpdateUserRequest request)
        {
            UpdateUserResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("{Id}")]
        [Authorize]
        public async Task<IActionResult> GetUserByUserId([FromRoute] GetUserByUserIdRequest request)
        {
            GetUserByUserIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
