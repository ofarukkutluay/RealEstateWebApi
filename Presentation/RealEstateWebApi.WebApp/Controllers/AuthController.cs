using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.Json;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RealEstateWebApi.WebApp.Models;


namespace RealEstateWebApi.WebApp.Controllers
{
    [AllowAnonymous]
    public class AuthController : BaseController
    {
        private readonly HttpClient _httpClient;

        public AuthController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient("ApiClient");
        }

        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("/login")]
        public async Task<IActionResult> Login(LoginUser loginUser)
        {
            
            var content = JsonContent.Create(loginUser);

            var response = await _httpClient.PostAsync("/user/login", content);

            JObject json = JObject.Parse(await response.Content.ReadAsStringAsync());

            //JsonWebToken jwt = new(json["data"]["token"].ToString()); //token decode için


            if ((bool)json["success"] == true)
            {

                var responseToken = json["data"]["token"].ToString();
                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                var token = handler.ReadJwtToken(responseToken);
                var claims = token.Claims.ToList();
                var expiration = json["data"]["expiration"].ToString();

                if (responseToken != null)
                {
                    claims.Add(new Claim("realestatetoken", responseToken));
                    var claimsIdentity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);
                    var authProps = new AuthenticationProperties
                    {
                        ExpiresUtc = DateTime.Parse(expiration),
                        IsPersistent = true
                    };

                    await HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProps);
                    //HttpContext.Session.SetString("Token",responseToken);
                    SuccessAlert(json["message"].ToString());
                    return RedirectToAction("Index", "Home");
                }

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
            

            var content = JsonContent.Create(registerUser);

            var response = await _httpClient.PostAsync("/user/register", content);

            JObject json = JObject.Parse(await response.Content.ReadAsStringAsync());

            if ((bool)json["success"] == true)
            {
                SuccessAlert(json["message"].ToString());
                return RedirectToAction("Login");
            }

            DangerAlert(json["message"].ToString());

            return RedirectToAction("Register");
        }

        [Route("/logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();
            //HttpContext.Session.Remove("Token");
            return RedirectToAction("Login");
        }
    }
}
