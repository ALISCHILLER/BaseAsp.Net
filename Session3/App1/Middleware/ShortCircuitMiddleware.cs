using App.Model;

namespace App.Middleware
{
    public class ShortCircuitMiddleware
    {
        private RequestDelegate _next;

        public ShortCircuitMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        //! Version - 1.0
        // public async Task InvokeAsync(HttpContext context)
        // {
        //     var result = context.Request.Headers["User-Agent"].Any(value => value.Contains("Trident"));

        //     if (result)
        //     {
        //         await context.Response.WriteAsync("Can not support!");
        //     }
        //     else
        //     {
        //         //? Pipeline
        //         await _next.Invoke(context);
        //     }
        // }

        //! Version - 2.0
        // public async Task InvokeAsync(HttpContext context)
        // {
        //     var result = context.Items["InvalidBrowser"] as bool?;

        //     if (!result.HasValue) 
        //     {
        //         throw new InvalidOperationException("Not Registered RequestEditingMiddleware");
        //     }
        //     else if (result.Value)
        //     {
        //         await context.Response.WriteAsync("Can not support!");
        //     }
        //     else
        //     {
        //         //? Pipeline
        //         await _next.Invoke(context);
        //     }
        // }

        //! Version - 3.0
        public async Task InvokeAsync(HttpContext context)
        {
            var result = context.Items["InvalidBrowser"] as bool?;

            if (!result.HasValue) 
            {
                throw new InvalidOperationException("Not Registered RequestEditingMiddleware");
            }
            else if (result.Value)
            {
                context.Items["Reject"] = "Can not support!";
            }
            else
            {
                //? Pipeline
                await _next.Invoke(context);
            }
        }


    }
}