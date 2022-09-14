namespace App.Middleware.Extensions
{
    public static class ContentGenerationMiddlewareExtension
    {
        //! Version 1.0
        // public static void UseContentGeneration(this IApplicationBuilder app)
        // {
        //     //? Pre Logic
            
        //     app.UseMiddleware<ContentGenerationMiddleware>();
        // }

        //! Version 2.0
        public static IApplicationBuilder UseContentGeneration(this IApplicationBuilder app)
        {
            //? Pre Logic
            
            return app.UseMiddleware<ContentGenerationMiddleware>();
        }        
    }
}