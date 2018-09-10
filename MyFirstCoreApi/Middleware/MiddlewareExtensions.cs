using Microsoft.AspNetCore.Builder;

namespace MyFirstCoreApi.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseTimestamp(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TimestampMiddleware>();
        }
    }
}
