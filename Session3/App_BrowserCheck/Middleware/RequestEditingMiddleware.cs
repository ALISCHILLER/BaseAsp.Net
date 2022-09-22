using App_BrowserCheck.Middleware.Core;
using App_BrowserCheck.Model;
using App_BrowserCheck.Service;

namespace App_BrowserCheck.Middleware
{
    public class RequestEditingMiddleware
    {
        private RequestDelegate _next;

        //? Structrual Dependency
        // private BrowserCheckService _browserCheckService;

        // public RequestEditingMiddleware(RequestDelegate next)
        // {
        //     _next = next;
        //     _browserCheckService = new BrowserCheckService();
        // }

        private IBrowserCheckService _browserCheckService;

        //? Constructor Injection
        //? Method Injection
        //? Property Injection
        public RequestEditingMiddleware(RequestDelegate next, IBrowserCheckService browserCheckService)
        {
            _next = next;
            _browserCheckService = browserCheckService;
        }        


        // public async Task InvokeAsync(HttpContext context)
        // {
        //     var result = context.Request.Headers["User-Agent"].Any(value => value.Contains("Trident"));
        //     //? 
        //     context.Items["InvalidBrowser"] = result;
            
        //     //? Pipeline
        //     await _next.Invoke(context);
        // }

        // public async Task InvokeAsync(HttpContext context)
        // {
        //     //? Behavioural Dependency
        //     var browserCheckService = new BrowserCheckService();

        //     var result = browserCheckService.Validate(context);

        //     context.Items["InvalidBrowser"] = result;
            
        //     //? Pipeline
        //     await _next.Invoke(context);
        // }        

        public async Task InvokeAsync(HttpContext context)
        {
            var result = _browserCheckService.Validate(context);

            context.Items["InvalidBrowser"] = result;
            
            //? Pipeline
            await _next.Invoke(context);
        }           
    }
}