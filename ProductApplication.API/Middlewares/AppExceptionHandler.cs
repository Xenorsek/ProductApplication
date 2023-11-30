using Microsoft.AspNetCore.Diagnostics;
using ProductApplication.Common;

namespace ProductApplication.API.Middlewares
{
    public class AppExceptionHandler : IExceptionHandler
    {
        private readonly ILogger<AppExceptionHandler> _logger;

        public AppExceptionHandler(ILogger<AppExceptionHandler> logger)
        {
            _logger = logger;
        }

        public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            (int statusCode, string errorMessage) = exception switch
            {
                DatabaseOverPopulatedException databaseException => (409, databaseException.Message),
                _ => (500, "Something went wrong")
            };

            httpContext.Response.StatusCode = statusCode;
            await httpContext.Response.WriteAsync(errorMessage);

            _logger.LogError(exception, exception.Message);

            return true;
        }
    }
}
