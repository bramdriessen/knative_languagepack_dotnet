using CloudNative.CloudEvents;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<Handler>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapPost("/", (Handler handler, [FromBody]CloudEvent cloudEvent) =>
{
    handler.HandleEvent(cloudEvent);
});

app.Run();