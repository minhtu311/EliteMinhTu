using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
namespace MinhTuNetCore
{
    public class MyCustomMiddleware1
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public System.Collections.Specialized.NameValueCollection QueryString { get; }

        public MyCustomMiddleware1(RequestDelegate next, ILoggerFactory logFactory)
        {
            _next = next;

            _logger = logFactory.CreateLogger("MyCustomerMiddleware");
        }

        public async Task Invoke(HttpContext httpContext)
        {
            
            _logger.LogInformation("MyMiddleware executing..");
            _logger.LogWarning(httpContext.Request.QueryString.ToString());
            await WriteToFile(httpContext);

            await _next(httpContext); // calling next middleware

        }

        public static async Task WriteToFile(HttpContext httpContext)
        {
            string[] lines =
            {
            httpContext.Request.Scheme.ToString(),
            httpContext.Request.Host.ToString(),
            httpContext.Request.Path.ToString(),
            httpContext.Request.QueryString.ToString(),
            httpContext.Request.Body.ToString()
        };

            await File.WriteAllLinesAsync("WriteLines.txt", lines);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MyCustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyMiddle1(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyCustomMiddleware1>();
        }
    }
}