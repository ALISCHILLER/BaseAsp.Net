namespace App.Middleware.Extensions
{
    public static class RequestEditingMiddlewareExtension
    {
        // public static void UseRequestEditing(this IApplicationBuilder app)
        // {
        //     //? Pre Logic
            
        //     app.UseMiddleware<RequestEditingMiddleware>();
        // }

        public static IApplicationBuilder UseRequestEditing(this IApplicationBuilder app)
        {
            //? Pre Logic
            
            return app.UseMiddleware<RequestEditingMiddleware>();
        }        
    }
}