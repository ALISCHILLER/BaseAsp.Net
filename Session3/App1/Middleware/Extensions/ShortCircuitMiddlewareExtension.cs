namespace App.Middleware.Extensions
{
    public static class ShortCircuitMiddlewareExtension
    {
        // public static void UseShortCircuit(this IApplicationBuilder app)
        // {
        //     //? Pre Logic
            
        //     app.UseMiddleware<ShortCircuitMiddleware>();
        // }

        public static IApplicationBuilder UseShortCircuit(this IApplicationBuilder app)
        {
            //? Pre Logic
            
            return app.UseMiddleware<ShortCircuitMiddleware>();
        }        
    }
}