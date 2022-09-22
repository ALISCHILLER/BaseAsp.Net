using App_BrowserCheck.Middleware.Core;

namespace App_BrowserCheck.Service.Extensions
{
    public static class BrowserCheckServiceExtenion
    {
        public static IServiceCollection AddBrowserCheckService(this IServiceCollection services)
        {
            //? Pre Logic 

            return services.AddTransient<IBrowserCheckService, BrowserCheckService>();
            // builder.Services.AddScoped<IBrowserCheckService, BrowserCheckService>();
            // builder.Services.AddSingleton<IBrowserCheckService, BrowserCheckService>();
        }
    }
}