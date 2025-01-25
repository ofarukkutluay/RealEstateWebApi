using Newtonsoft.Json;
using RealEstateWebApi.WebApp.Models;
using RealEstateWebApi.WebApp.Models.Common;
using RealEstateWebApi.WebApp.Services.ApiRequest;
using RealEstateWebApi.WebApp.Services.Logger;
using System.Diagnostics;
using System.Net;
using System.Security.Claims;

namespace RealEstateWebApi.WebApp.Middlewares
{
    public class CustomExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerService _loggerService;
        private readonly ApiRequestService _apiRequestService;

        public CustomExceptionMiddleware(RequestDelegate next, ILoggerService loggerService, ApiRequestService apiRequestService)
        {
            _next = next;
            _loggerService = loggerService;
            _apiRequestService = apiRequestService;
        }

        public async Task Invoke(HttpContext context)
        {

            var watch = Stopwatch.StartNew();
            try
            {
                string message = $"[Request]  HTTP {context.Request.Method} - {context.Request.Path} - {context.Connection.RemoteIpAddress} : {context.Connection.RemotePort}";
                _loggerService.Write(message);

                await _next(context);
                watch.Stop();

                message = $"[Response] HTTP {context.Request.Method} - {context.Request.Path} responded {context.Response.StatusCode} in {watch.Elapsed.TotalMilliseconds} ms";
                _loggerService.Write(message);
            }
            catch (Exception ex)
            {
                watch.Stop();
                await HandleException(context, ex, watch);
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                string message = $"[Error]    HTTP {context.Request.Method} - {context.Response.StatusCode} Error Message: {ex.Message} in {watch.Elapsed.TotalMilliseconds} ms";
                _loggerService.Write(message);

                string? userId = context.User.Claims.FirstOrDefault(e => e.Type == ClaimTypes.NameIdentifier).Value ?? null;
                string subject = $"{userId} UserId'nin clientta oluşturduğu hata";
                string body = $"Hata alındı : {message}";
                //await _apiRequestService.Post<Result>("contact/postmail", new { To = "ofarukkutluay@outlook.com", Subject = subject, Body = body });
            }
        }
        private Task HandleException(HttpContext context, Exception ex, Stopwatch watch)
        {
         
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            string message = $"[Error]    HTTP {context.Request.Method} - {context.Response.StatusCode} Error Message: {ex.Message} in {watch.Elapsed.TotalMilliseconds} ms";
            _loggerService.Write(message);

            var result = JsonConvert.SerializeObject(new { Error = ex.Message }, Formatting.None);

            return context.Response.WriteAsync(result);
        }
    }

    public static class CustomExceptionMiddlewareExtension
    {
        public static IApplicationBuilder UseCustomExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionMiddleware>();
        }
    }

}
