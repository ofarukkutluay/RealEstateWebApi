using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Results;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new ApiResult<object>()
            {
                Message ="Api running... See documentation.",
                Success = true
            });
        }
    }
}
