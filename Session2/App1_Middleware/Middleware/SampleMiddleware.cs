namespace App1_Middleware.Middleware
{

    //? Built-In
    //? Inherit
    //?Naming Convention
    public class SampleMiddleware
    {

        //*Pipeline
        private RequestDelegate _next;

        public SampleMiddleware(RequestDelegate next)
        {
            _next=next;
        }
        // //!Sync 
        // public void Invoke(HttpContext context)
        // {
        //     // context.Request
        //    //  context.Response

        // }
        
        
        public async Task InvokeAsync(HttpContext context)
        {
            // context.Request
           //  context.Response
          // await context.Response.WriteAsync("Sample Text");
          var product =new Product 
          {
            Id =1,
            nameof ="Sample product"
          };
        }
    }
}