using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.Application.Abstractions.Security;
using RealEstateWebApi.Application.Abstractions.Services;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Application.Results;
using RealEstateWebApi.Domain.Entities.LocalDb;
using System.Security.Claims;

namespace RealEstateWebApi.WebApi.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {
        private readonly ITemporaryPassService _temporaryPassService;

        public HomeController(ITemporaryPassService temporaryPassService)
        {
            _temporaryPassService = temporaryPassService;
        }

        [HttpGet]
        public IActionResult Index()
        {

            string guid = _temporaryPassService.Generate();

            return Ok(new ApiResult<object>()
            {
                Message = "Api running... See documentation.",
                InternalMessage = guid,
                Success = true
            });
        }

    }
}
