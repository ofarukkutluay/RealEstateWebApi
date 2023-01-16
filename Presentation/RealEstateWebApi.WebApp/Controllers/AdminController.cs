using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.WebApp.Models;
using RealEstateWebApi.WebApp.Models.Common;
using RealEstateWebApi.WebApp.Services.ApiRequest;
using Serilog.Sinks.InMemory;
using System.Security.Claims;

namespace RealEstateWebApi.WebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : BaseController
    {
        private readonly ApiRequestService _apiRequestService;

        public AdminController(ApiRequestService apiRequestService)
        {
            _apiRequestService = apiRequestService;
        }

        public IActionResult Logs()
        {
            IEnumerable<Serilog.Events.LogEvent> loglist = InMemorySink.Instance.LogEvents;
            return View(loglist);
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Users()
        {
            var homeResult = await _apiRequestService.GetApiStatus();
            DataResult<IEnumerable<User>> users = await _apiRequestService.Get<DataResult<IEnumerable<User>>>("user", "?TempPass=", homeResult.InternalMessage);
            uint loginUserId = uint.Parse(HttpContext.User.Claims.FirstOrDefault(e => ClaimTypes.NameIdentifier == e.Type).Value);
            await SelectItemInitilazeRolesModalPage();

            return View(users.Data.Where(x => x.Id != loginUserId));
        }

        public async Task<IActionResult> ActivateUser(uint userId)
        {
            var homeResult = await _apiRequestService.GetApiStatus();
            Result result = await _apiRequestService.Put<Result>("user/changeActivate", new { TempPass = homeResult.InternalMessage, UserId = userId, Activate = true });
            if (result.Success)
            {
                SuccessAlert(result.Message);
                return RedirectToAction("Users");
            }

            DangerAlert(result.Message);
            return RedirectToAction("Users");

        }

        public async Task<IActionResult> DeactivateUser(uint userId)
        {
            var homeResult = await _apiRequestService.GetApiStatus();
            Result result = await _apiRequestService.Put<Result>("user/changeActivate", new { TempPass = homeResult.InternalMessage, UserId = userId, Activate = false });
            if (result.Success)
            {
                SuccessAlert(result.Message);
                return RedirectToAction("Users");
            }

            DangerAlert(result.Message);
            return RedirectToAction("Users");

        }

        public async Task<IActionResult> UserUpdate(uint userId)
        {
            DataResult<User> user = await _apiRequestService.Get<DataResult<User>>("user", "/", userId.ToString());
            return View(user.Data);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUser(User user)
        {
            Result result = await _apiRequestService.Put<Result>("user", user);
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
            Result result = await _apiRequestService.PostForm<Result>("user/uploadPhoto", userPhoto);
            if (result.Success)
            {
                SuccessAlert(result.Message);
                return Redirect(Request.Headers["Referer"].ToString());
            }

            DangerAlert(result.Message);
            return Redirect(Request.Headers["Referer"].ToString());
        }

        public async Task<IActionResult> CreatePassword(uint userId)
        {
            var homeResult = await _apiRequestService.GetApiStatus();
            DataResult<string> result = await _apiRequestService.Post<DataResult<string>>("user/createAndChangePassword", new { TempPass = homeResult.InternalMessage, UserId = userId });
            if (result.Success)
            {
                SuccessAlert(result.Message + ". Şifre : " + result.Data);
                return RedirectToAction("Users");
            }

            DangerAlert(result.Message);
            return RedirectToAction("Users");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUserRole(UserRole userRole)
        {
            Result result = await _apiRequestService.Post<Result>("UserOperationClaim", new { UserId = userRole.UserId, OperationClaimId = userRole.OperationClaimId });
            if (result.Success)
            {
                SuccessAlert(result.Message);
                return Redirect(Request.Headers["Referer"].ToString());
            }

            DangerAlert(result.Message);
            return Redirect(Request.Headers["Referer"].ToString());
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUserRoles(UserRole userRole)
        {
            var userRoles = await _apiRequestService.Get<DataResult<IEnumerable<UserRole>>>("UserOperationClaim", "/", userRole.UserId.ToString());
            Result result = new Result();
            
            foreach (var item in userRoles.Data)
            {
                result = await _apiRequestService.Delete<Result>("UserOperationClaim", new { UserId = userRole.UserId, OperationClaimId = item.OperationClaimId});
            }

            if (result.Success)
            {
                SuccessAlert(result.Message);
                return Redirect(Request.Headers["Referer"].ToString());
            }

            DangerAlert(result.Message);
            return Redirect(Request.Headers["Referer"].ToString());
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCustomer(Customer customer)
        {
            var rtnObj = await _apiRequestService.Delete<Result>("customer", new { Id = customer.Id});

            if (rtnObj.Success == true)
            {
                SuccessAlert(rtnObj.Message);
                return Redirect("/customer");
            }

            DangerAlert(rtnObj.Message);
            return Redirect("/customer/" + customer.Id);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateCustomer(Customer customer)
        {
            var rtnObj = await _apiRequestService.Put<Result>("customer", customer);

            if (rtnObj.Success == true)
            {
                SuccessAlert(rtnObj.Message);
                return Redirect(Request.Headers["Referer"].ToString());
            }

            DangerAlert(rtnObj.Message);
            return Redirect(Request.Headers["Referer"].ToString());
        }

        public async Task<IActionResult> ActivateCustomer(uint customerId)
        {
            var rtnObj = await _apiRequestService.Put<Result>("customer/ChangeActivate", new {CustomerId = customerId , Activate = true});

            if (rtnObj.Success == true)
            {
                SuccessAlert(rtnObj.Message);
                return Redirect(Request.Headers["Referer"].ToString());
            }

            DangerAlert(rtnObj.Message);
            return Redirect(Request.Headers["Referer"].ToString());
        }

        public async Task<IActionResult> DeleteOwnedProperty(uint cospId)
        {
            var rtnObj = await _apiRequestService.Delete<Result>("CustomerOwnedProperty", new { Id = cospId });

            if (rtnObj.Success == true)
            {
                SuccessAlert(rtnObj.Message);
                return Redirect(Request.Headers["Referer"].ToString());
            }

            DangerAlert(rtnObj.Message);
            return Redirect(Request.Headers["Referer"].ToString());
        }

        public async Task<IActionResult> DeleteSearchProperty(uint csspId)
        {
            var rtnObj = await _apiRequestService.Delete<Result>("CustomerSearchProperty", new { Id = csspId });

            if (rtnObj.Success == true)
            {
                SuccessAlert(rtnObj.Message);
                return Redirect(Request.Headers["Referer"].ToString());
            }

            DangerAlert(rtnObj.Message);
            return Redirect(Request.Headers["Referer"].ToString());
        }

        async Task SelectItemInitilazeRolesModalPage()
        {

            var result = await _apiRequestService.Get<DataResult<IEnumerable<OperationClaim>>>("OperationClaim");

            IEnumerable<SelectListItem> selectRoles = result.Data.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            });

            ViewData.Add("Roles", selectRoles);
        }


    }
}
