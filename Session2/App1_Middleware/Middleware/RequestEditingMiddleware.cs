using App1_Middleware.Model;
namespace App1_Middleware.Middleware
{
    public class RequestEditingMiddleware
    {
          private RequestDelegate _next;

        public RequestEditingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var result = context.Request.Headers["User-Agent"].Any(value => value.Contains("Trident"));
            context.Items["InvalidBrowser"] = result;
            
            //? Pipeline
            await _next.Invoke(context);
        }
    }
}