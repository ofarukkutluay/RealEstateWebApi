using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstateWebApi.WebApp.Models;
using RealEstateWebApi.WebApp.Models.Common;
using RealEstateWebApi.WebApp.Services.ApiRequest;
using System.Diagnostics;

namespace RealEstateWebApi.WebApp.Controllers
{
    
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApiRequestService _requestService;

        public HomeController(ILogger<HomeController> logger, ApiRequestService requestService)
        {
            _logger = logger;
            _requestService = requestService;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            DataResult<IEnumerable<CustomerDto>> recentCustomers = await _requestService.Get<DataResult<IEnumerable<CustomerDto>>>("customer", "/recent", "?take=5");
            DataResult<int> countCustomer = await _requestService.Get<DataResult<int>>("customer","/count");
            ViewData.Add("CustomerCount",countCustomer.Data); 
            return View(recentCustomers.Data);
        }

        [Route("NotFound")]
        public IActionResult NotFound()
        {
            return View();
        }

        [Route("Forbidden")]
        public IActionResult Forbidden()
        {
            return View();
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