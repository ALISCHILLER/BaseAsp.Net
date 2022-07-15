
using App1_Middleware.Middleware;
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//? Middleware Registration
app.UseMiddleware<SampleMiddleware>();

app.Run();