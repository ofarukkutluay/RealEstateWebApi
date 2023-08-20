using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.WebApp.Models;
using RealEstateWebApi.WebApp.Models.Common;
using RealEstateWebApi.WebApp.Services.ApiRequest;
using System.Diagnostics;
using System.Security.Claims;

namespace RealEstateWebApi.WebApp.Controllers
{
    
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApiRequestService _requestService;
        private readonly IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger, ApiRequestService requestService, IConfiguration configuration)
        {
            _logger = logger;
            _requestService = requestService;
            _configuration = configuration;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            uint userId = uint.Parse(HttpContext.User.Claims.First(e => e.Type == ClaimTypes.NameIdentifier).Value);

            DataResult<IEnumerable<CustomerDto>> recentCustomers = await _requestService.Get<DataResult<IEnumerable<CustomerDto>>>("customer", "/recent", "?firstDate=" + DateTime.UtcNow.Date);
            DataResult<IEnumerable<CustomerDto>> recentCustomersByUserId = await _requestService.Get<DataResult<IEnumerable<CustomerDto>>>("customer", "/recent", "?firstDate=" + DateTime.UtcNow.Date, "&userId=" + userId);
            DataResult<int> countCustomer = await _requestService.Get<DataResult<int>>("customer","/count");
            DataResult<IEnumerable<Reminder>> remiders = await _requestService.Get<DataResult<IEnumerable<Reminder>>>("reminder", "?userId="+userId);
            DataResult<int> countEntry = await _requestService.Get<DataResult<int>>("entry", "/count", "?userId=" + userId,"&firstDate="+DateTime.UtcNow.Date);
            ViewData.Add("CustomerCount",countCustomer.Data);
            ViewData.Add("EntryCount", countEntry.Data);
            ViewData.Add("RecentCustomerCount", recentCustomersByUserId.Data.Count());
            ViewBag.reminders = remiders.Data;

            _logger.LogInformation("Ana sayfaya girildi");
            _logger.LogCritical("Kritik ana sayfa aksiyonu");
            return View(recentCustomers.Data);
        }

        [Route("NotFound")]
        public IActionResult NotFoundPage()
        {
            return View();
        }

        [Route("Forbidden")]
        public IActionResult Forbidden()
        {
            return View();
        }

        [Route("Contact")]
        public IActionResult Contact()
        {
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(SendMessage sendMessage)
        {
            uint userId = uint.Parse(HttpContext.User.Claims.First(e => e.Type == ClaimTypes.NameIdentifier).Value);
            string subject = $"{userId} UserId'nin iletişim den oluşturulmuş mesajı";
            string body = $"Adı : {sendMessage.Name} <br> Mail : {sendMessage.Mail} <br> Subject : {sendMessage.Subject} <br> Mesajı: {sendMessage.Message}";
            Result result = await _requestService.Post<Result>("contact/postmail", new { To = _configuration["Contact"], Subject = subject, Body = body });
            if (result.Success)
                SuccessAlert("Mesaj Gönderildi");
            return RedirectToAction("Contact");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}