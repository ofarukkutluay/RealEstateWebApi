using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Features.Commands.Extension.ChromeExtension;
using RealEstateWebApi.Infrastructure.Services.Scraping;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class ExtensionController : Controller
    {
        private readonly IMediator _mediator;

        public ExtensionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Index(ChromeExtensionRequest request)
        {
            ChromeExtensionResponse response = await _mediator.Send(request);

            return Ok(response);
        }
    }
}
