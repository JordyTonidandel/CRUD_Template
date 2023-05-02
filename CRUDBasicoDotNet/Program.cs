using CRUDBasicoDotNet.Controllers.PackControllerExample;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapMethods(ControllerExample.Template, ControllerExample.Methods, ControllerExample.Handle);

app.Run();
