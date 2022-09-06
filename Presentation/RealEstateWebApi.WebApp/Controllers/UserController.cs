using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.WebApp.Models;
using RealEstateWebApi.WebApp.Models.Common;
using RealEstateWebApi.WebApp.Services.ApiRequest;
using System.Security.Claims;

namespace RealEstateWebApi.WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly ApiRequestService _requestService;

        public UserController(ApiRequestService requestService)
        {
            _requestService = requestService;
        }

        [HttpGet("/profile")]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            uint userId = uint.Parse(HttpContext.User.Claims.FirstOrDefault(e => ClaimTypes.NameIdentifier == e.Type).Value);
            DataResult<User> user = await _requestService.Get<DataResult<User>>("user", "/", userId.ToString());
            return View(user.Data);
        }
    }
}
