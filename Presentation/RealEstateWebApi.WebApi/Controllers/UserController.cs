﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.User.LoginUser;
using RealEstateWebApi.Application.Features.Commands.User.LogoutUser;
using RealEstateWebApi.Application.Features.Commands.User.RegisterUser;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
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