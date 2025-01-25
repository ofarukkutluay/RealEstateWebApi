using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RealEstateWebApi.WebApp.Models;
using RealEstateWebApi.WebApp.Models.Common;
using RealEstateWebApi.WebApp.Services.ApiRequest;
using System.Security.Claims;

namespace RealEstateWebApi.WebApp.Controllers
{
    public class UserController : BaseController
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

        [HttpPost]
        public async Task<IActionResult> ChangePasswordUser(ChangePasswordUser changePasswordUser)
        {
            Result result = await _requestService.Post<Result>("User/ChangePassword", changePasswordUser);
            if (result.Success)
            {
                SuccessAlert(result.Message);
                return Redirect(Request.Headers["Referer"].ToString());
            }

            DangerAlert(result.Message);
            return Redirect(Request.Headers["Referer"].ToString());
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(User user)
        {
            Result result = await _requestService.Put<Result>("user",user);

            if (result.Success)
            {
                SuccessAlert(result.Message);
                return Redirect(Request.Headers["Referer"].ToString());
            }

            DangerAlert(result.Message);
            return Redirect(Request.Headers["Referer"].ToString());
        }

        [HttpPost]
        public async Task<IActionResult> UploadPhoto(UserPhoto userPhoto)
        {
            Result result = await _requestService.PostForm<Result>("user/uploadPhoto", userPhoto);
            if (result.Success)
            {
                SuccessAlert(result.Message);
                return Redirect(Request.Headers["Referer"].ToString());
            }

            DangerAlert(result.Message);
            return Redirect(Request.Headers["Referer"].ToString());
        }
    }
}
