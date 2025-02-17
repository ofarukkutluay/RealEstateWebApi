using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.Reminder.CreateReminder;
using RealEstateWebApi.Application.Features.Commands.Reminder.DeleteReminder;
using RealEstateWebApi.Application.Features.Commands.Reminder.UpdateReminder;
using RealEstateWebApi.Application.Features.Queries.Reminder.GetAllReminderDtoByUserId;
using RealEstateWebApi.Application.Features.Queries.Reminder.GetAllReminderDtoByCustomerId;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ReminderController : Controller
	{
        private readonly IMediator _mediator;

        public ReminderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateReminder(CreateReminderRequest request)
        {
            CreateReminderResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateReminder(UpdateReminderRequest request)
        {
            UpdateReminderResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteReminder(DeleteReminderRequest request)
        {
            DeleteReminderResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllReminderDtoByUserId([FromQuery]GetAllReminderDtoByUserIdRequest request)
        {
            GetAllReminderDtoByUserIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }

        [HttpGet("customer")]
        public async Task<IActionResult> GetAllReminderDtoByCustomerId([FromQuery]GetAllReminderDtoByCustomerIdRequest request)
        {
            GetAllReminderDtoByCustomerIdResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}

