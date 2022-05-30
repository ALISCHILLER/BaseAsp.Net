//? File Scope Namespace

//? Explicit Using
// using Microsoft.AspNetCore.Builder;

using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

//! Single Request Handler
// app.MapGet("/", ()=> "Hello World!");

//! Multiple Request Handler

app.Use(async (context, next) =>
{
    app.Logger.LogInformation($"Start Time : {DateTime.Now.ToString()}");

    await next.Invoke();

    app.Logger.LogInformation($"Stop Time : {DateTime.Now.ToString()}");
});

//* Ordering System
app.MapGet("/", async () => await Task.FromResult("Hello World!"));



app.Run();
