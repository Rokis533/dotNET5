using Microsoft.AspNetCore.Http;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using Microsoft.Extensions.Logging;

namespace PotatoApi
{
    public class GlobalExceptionHandlingMidleware
    {

        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionHandlingMidleware> _logger;

        public GlobalExceptionHandlingMidleware(RequestDelegate next, ILogger<GlobalExceptionHandlingMidleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (IamNotHappyException ex)
            {
                _logger.LogWarning(ex.Message);
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = 200;
                var respose = new
                {
                    Message = "I am fine",
                };
                await httpContext.Response.WriteAsJsonAsync(respose);
            }
            catch (DivideByZeroException ex)
            {
                _logger.LogWarning(ex.Message);
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = 400;
                var respose = new
                {
                    Message = "You cannot divide by 0",
                };
                await httpContext.Response.WriteAsJsonAsync(respose);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = 500;
                var respose = new
                {
                    Message = "Unexpected error please contact administrator",
                };
                await httpContext.Response.WriteAsJsonAsync(respose);

            }
        }

    }
}
