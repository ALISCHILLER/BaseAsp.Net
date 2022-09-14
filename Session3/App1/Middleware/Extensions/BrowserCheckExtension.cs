namespace App.Middleware.Extensions
{
    //! Combine
    public static class BrowserCheckExtension
    {
        // public static void UseBrowserCheck(this IApplicationBuilder app)
        // {
        //     //? Pre Logic

        //     app.UseResponseEditing();
        //     app.UseRequestEditing();
        //     app.UseShortCircuit();
        //     app.UseContentGeneration();
        // }

        // public static void UseBrowserCheck(this IApplicationBuilder app)
        // {
        //     //? Pre Logic

        //     //! Fluent Pattern

        //     app
        //         .UseResponseEditing()
        //         .UseRequestEditing()
        //         .UseShortCircuit()
        //         .UseContentGeneration();
        // }       

        public static void UseBrowserCheck(this IApplicationBuilder app, IWebHostEnvironment env)
        {
            //? Pre Logic

            //! Fluent Pattern

            //? Conditional Registration
            
            if (env.IsProduction())
            {
                app
                    .UseResponseEditing()
                    .UseRequestEditing()
                    .UseShortCircuit()
                    .UseContentGeneration();
            }
            else
            {
                app
                    .UseResponseEditing()
                    .UseContentGeneration();
            }
        }
    }
}