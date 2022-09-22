using App_BrowserCheck.Model;

namespace App_BrowserCheck.Middleware
{
    public class ContentGenerationMiddleware
    {
        private RequestDelegate _next;

        public ContentGenerationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        //! Version - 1.0
        // public async Task InvokeAsync(HttpContext context)
        // {
        //     var result = context.Request.Headers["User-Agent"].Any(value => value.Contains("Trident"));

        //     if (!result)
        //     {
        //         var product = new Product
        //         {
        //             Id = 1,
        //             Name = "Sample Product"
        //         };

        //         await context.Response.WriteAsJsonAsync(product);
        //     }
        //     else
        //     {
        //         await context.Response.WriteAsync("Can not support!");
        //     }
        // }

        //! Version - 2.0
        // public async Task InvokeAsync(HttpContext context)
        // {
        //     var product = new Product
        //     {
        //         Id = 1,
        //         Name = "Sample Product"
        //     };

        //     await context.Response.WriteAsJsonAsync(product);
        // }


        //! Version - 3.0
        public async Task InvokeAsync(HttpContext context)
        {
            await Task.Run(() =>
            {
                //? ProductService
                var product = new Product
                {
                    Id = 1,
                    Name = "Sample Product"
                };

                context.Items["Content"] = product;
            });
        }
    }
}