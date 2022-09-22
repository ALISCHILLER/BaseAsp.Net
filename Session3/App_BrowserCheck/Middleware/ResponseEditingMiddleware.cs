using App_BrowserCheck.Model;

namespace App_BrowserCheck.Middleware
{
    public class ResponseEditingMiddleware
    {
        private RequestDelegate _next;

        public ResponseEditingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //? Pipeline
            await _next.Invoke(context);


            var reject = context.Items["Reject"] as string;

            if (!string.IsNullOrEmpty(reject))
            {
                await context.Response.WriteAsync(reject);
            }
            else
            {
                var product = context.Items["Content"] as Product;

                await context.Response.WriteAsJsonAsync(product);
            }

        }
    }
}