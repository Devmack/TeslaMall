using System.Net;
using TeslaMall.Server.Exceptions;

namespace TeslaMall.Server.Middleware;

public class ExceptionInterceptorMiddleware 
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionInterceptorMiddleware> _logger;
    public ExceptionInterceptorMiddleware(RequestDelegate next, ILogger<ExceptionInterceptorMiddleware> logger)
    {
        _logger = logger;
        _next = next;
    }
    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (DateException ex)
        {
            _logger.LogError($"Date error: {ex}");
            await HandleExceptionAsync(httpContext, ex);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Something went wrong: {ex}");
            await HandleExceptionAsync(httpContext, ex);
        }
    }
    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
        await context.Response.WriteAsync($"error: {exception.Message}");
    }
}
