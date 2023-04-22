using MiWrap;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterHandlers<Program>();

var app = builder.Build();

app.MapEndpoints<Program>();
app.MapGet("/", () => "Hello World!");

app.Run();