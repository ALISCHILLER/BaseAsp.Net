namespace App.Middleware.Extensions
{
    public static class ResponseEditingMiddlewareExtension
    {
        // public static void UseResponseEditing(this IApplicationBuilder app)
        // {
        //     //? Pre Logic
            
        //     app.UseMiddleware<ResponseEditingMiddleware>();
        // }

        public static IApplicationBuilder UseResponseEditing(this IApplicationBuilder app)
        {
            //? Pre Logic
            
            return app.UseMiddleware<ResponseEditingMiddleware>();
        }        
    }
}