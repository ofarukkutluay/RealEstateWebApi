using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RealEstateWebApi.WebApp.Data.Local;
using RealEstateWebApi.WebApp.Middlewares;
using RealEstateWebApi.WebApp.Models.Common;
using RealEstateWebApi.WebApp.Services.ApiRequest;
using RealEstateWebApi.WebApp.Services.Logger;
using Serilog;
using Serilog.Context;
using Serilog.Core;
using Serilog.Sinks.InMemory;
using System.Net;
using System.Security.Claims;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<WebAppLocalDbContext>(opt => opt.UseInMemoryDatabase("LocalDb"));

builder.Services.AddSingleton<ILoggerService, ConsoleLogger>();
builder.Services.AddScoped<ApiRequestService>();

//var tokenOptions = builder.Configuration.GetSection("ApiTokenOptions").Get<ApiTokenOption>();



builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddCookie(JwtBearerDefaults.AuthenticationScheme, opt =>
{
    opt.LoginPath = "/login";
    opt.LogoutPath = "/logout";
    opt.AccessDeniedPath = "/forbidden";
    opt.Cookie.HttpOnly = true;
    opt.Cookie.SameSite = SameSiteMode.Strict;
    opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
    opt.Cookie.Name = "REWAToken";
});

builder.Services.AddHttpContextAccessor();


builder.Services.AddHttpClient("ApiClient", (serviceProvider, client) =>
{
    var httpContextAccessor = serviceProvider.GetRequiredService<IHttpContextAccessor>();
    string? Token = httpContextAccessor.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == "realestatetoken")?.Value;
    client.BaseAddress = new Uri(builder.Configuration["ApiUrl"]);
    client.DefaultRequestHeaders.Add("Accept", "application/json");
    client.DefaultRequestHeaders.Add("User-Agent", "RealEstateWebApp");
    if (!string.IsNullOrEmpty(Token))
    {
        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Token}");
    }
});

Logger log = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/log.txt")
    .WriteTo.InMemory(restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Information)
    .Enrich.FromLogContext()
    .MinimumLevel.Information()
    .CreateLogger();

builder.Host.UseSerilog(log);

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All;
    logging.RequestHeaders.Add("sec-ch-ua");
    logging.MediaTypeOptions.AddText("application/javascript");
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
});

builder.Services.AddSession();

// Add services to the container.
builder.Services.AddControllersWithViews();


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSession();

app.UseSerilogRequestLogging();

app.UseHttpLogging();

//app.UseCustomExceptionMiddleware();


// app.Use(async (context, next) =>
// {
//     var token = context.User.Claims.FirstOrDefault(x => x.Type == "realestatetoken")?.Value; //context.Session.GetString("Token"); // //
//     if (!string.IsNullOrEmpty(token))
//     {
//         var scope = (ApiRequestService)app.Services.GetService(typeof(ApiRequestService));
//         if (scope != null)
//         {
//             scope.Token = token;
//         }
//         context.Request.Headers.Add("Authorization", "Bearer " + token);
//     }
//     await next();
// });




// app.UseStatusCodePages(async context =>
// {
//     var request = context.HttpContext.Request;
//     var response = context.HttpContext.Response;

//     if (response.StatusCode == (int)HttpStatusCode.Unauthorized)
//     {
//         response.Redirect("/login");
//     }
//     else if (response.StatusCode == (int)HttpStatusCode.Forbidden)
//     {
//         response.Redirect("/Forbidden");
//     }
//     if (response.StatusCode == (int)HttpStatusCode.NotFound)
//     {
//         response.Redirect("/NotFound");
//     }
// });

// app.UseCookiePolicy(new CookiePolicyOptions
// {
//     MinimumSameSitePolicy = SameSiteMode.Strict,
//     Secure = CookieSecurePolicy.Always
// });

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseForwardedHeaders(new ForwardedHeadersOptions
{
    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
});



app.UseAuthentication();
app.UseAuthorization();



app.Use(async (context, next) =>
{
    var userid = context.User?.Identity?.IsAuthenticated == true ? context.User.Claims.First(x => x.Type == ClaimTypes.NameIdentifier)?.Value : null;
    LogContext.PushProperty("user_id", userid);
    

    var remoteIpAddress = context.Connection.RemoteIpAddress?.ToString();
    LogContext.PushProperty("remote_ip", remoteIpAddress);
    await next();
});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
