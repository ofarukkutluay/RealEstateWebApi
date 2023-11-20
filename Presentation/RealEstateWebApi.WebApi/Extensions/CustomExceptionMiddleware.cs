
using Newtonsoft.Json;
using RealEstateWebApi.Application.Abstractions.Services;
using System.Diagnostics;
using System.Net;

namespace RealEstateWebApi.WebApi.Extensions
{
    public class CustomExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IMailService _mailService;

        public CustomExceptionMiddleware(RequestDelegate next, IMailService mailService)
        {
            _next = next;
            _mailService = mailService;
        }

        public async Task Invoke(HttpContext context)
        {

            var watch = Stopwatch.StartNew();
            try
            {
                string message = $"[Request]  HTTP {context.Request.Method} - {context.Request.Path} - {context.Connection.RemoteIpAddress} : {context.Connection.RemotePort}";
                Console.WriteLine(message);

                await _next(context);
                watch.Stop();

                message = $"[Response] HTTP {context.Request.Method} - {context.Request.Path} responded {context.Response.StatusCode} in {watch.Elapsed.TotalMilliseconds} ms";
                Console.WriteLine(message);
            }
            catch (Exception ex)
            {
                watch.Stop();
                await HandleException(context, ex, watch);
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                string message = $"[Error]    HTTP {context.Request.Method} - {context.Response.StatusCode} Error Message: {ex.Message} in {watch.Elapsed.TotalMilliseconds} ms {DateTime.Now}";
                // Console.WriteLine(message);
                //await _mailService.SendMailAsync("ofarukkutluay@outlook.com", $"Api hata mesajı", message);

            }

        }

        private Task HandleException(HttpContext context, Exception ex, Stopwatch watch)
        {
         
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            string message = $"[Error]    HTTP {context.Request.Method} - {context.Response.StatusCode} Error Message: {ex.Message} {ex.StackTrace} {ex.InnerException} {ex.HResult} in {watch.Elapsed.TotalMilliseconds} ms";
            Console.WriteLine(message);

            var result = JsonConvert.SerializeObject(ex, Formatting.None);

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
