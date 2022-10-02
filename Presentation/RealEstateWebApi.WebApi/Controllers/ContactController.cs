using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.Contact.PostMail;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ContactController : Controller
    {
        private readonly IMediator _mediator;

        public ContactController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("PostMail")]
        public async Task<IActionResult> PostMail(PostMailRequest request)
        {
            PostMailResponse response = await _mediator.Send(request);
            if (response.Success)
                return Ok(response);
            return BadRequest(response);
        }
    }
}
