
using App.Middleware;
using App.Middleware.Core;
using App.Middleware.Extensions;
using App.Service;
using App.Service.Extensions;

var builder = WebApplication.CreateBuilder(args);

//? Service Configuration
//! Version - 1.0
// builder.Services.AddTransient<IBrowserCheckService, BrowserCheckService>();
// builder.Services.AddScoped<IBrowserCheckService, BrowserCheckService>();
// builder.Services.AddSingleton<IBrowserCheckService, BrowserCheckService>();
//? Other Services

builder.Services.AddBrowserCheckService();

var app = builder.Build();

//! Middleware Registration

//! Version 1.0
// app.UseMiddleware<SampleMiddleware>();
// app.UseMiddleware<ResponseEditingMiddleware>();
// app.UseMiddleware<RequestEditingMiddleware>();
// app.UseMiddleware<ShortCircuitMiddleware>();
// app.UseMiddleware<ContentGenerationMiddleware>();

//! Version 2.0
// app.UseResponseEditing();
// app.UseRequestEditing();
// app.UseShortCircuit();
// app.UseContentGeneration();


//! Version 3.0
// app.UseBrowserCheck();

//! Version 4.0
app.UseBrowserCheck(app.Environment);

// app.Environment.EnvironmentName
// app.Environment.IsDevelopment

app.Run();