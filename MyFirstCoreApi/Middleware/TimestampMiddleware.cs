using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MyFirstCoreApi.Middleware
{
    public class TimestampMiddleware
    {
        private readonly RequestDelegate next;

        public TimestampMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var elapsedTime = Stopwatch.StartNew();
            context.Response.OnStarting(() =>
            {
                elapsedTime.Stop();
                context.Response.Headers.Add("Process-Time", $"{elapsedTime.ElapsedMilliseconds.ToString()}ms");
                return Task.CompletedTask;
            });
            await this.next(context);
        }
    }
}
