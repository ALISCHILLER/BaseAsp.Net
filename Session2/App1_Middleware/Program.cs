
using App1_Middleware.Middleware;
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//? Middleware Registration
//! Middleware Registration
// app.UseMiddleware<SampleMiddleware>();
app.UseMiddleware<ResponseEditingMiddleware>();
app.UseMiddleware<RequestEditingMiddleware>();
app.UseMiddleware<ShortCircuitMiddleware>();
app.UseMiddleware<ContentGenerationMiddleware>();

app.Run();