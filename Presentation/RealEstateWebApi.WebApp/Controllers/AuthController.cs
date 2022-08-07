using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RealEstateWebApi.WebApp.Models;

namespace RealEstateWebApi.WebApp.Controllers
{
    public class AuthController : BaseController
    {
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("/login")]
        public async Task<IActionResult> Login(LoginUser loginUser)
        {
            HttpClient client = new HttpClient();

            var content = JsonContent.Create(loginUser);

            var response = await client.PostAsync(_configuration["ApiUrl"] + "user/login", content);

            JObject json = JObject.Parse(await response.Content.ReadAsStringAsync());

            if ((bool)json["success"] == true)
            {
                HttpContext.Session.SetString("Token", json["data"]["token"].ToString());
                SuccessAlert(json["message"].ToString());
                return RedirectToAction("Index", "Home");
            }

            DangerAlert(json["message"].ToString());
            return RedirectToAction("Login");

        }

        [Route("/register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("/register")]
        public async Task<IActionResult> Register(RegisterUser registerUser)
        {
            HttpClient client = new HttpClient();

            var content = JsonContent.Create(registerUser);

            var response = await client.PostAsync(_configuration["ApiUrl"] + "user/register", content);

            JObject json = JObject.Parse(await response.Content.ReadAsStringAsync());

            if ((bool)json["success"] == true)
            {
                SuccessAlert(json["message"].ToString());
                return RedirectToAction("Login");
            }

            DangerAlert(json["message"].ToString());
            return RedirectToAction("Login");

        }
    }
}
