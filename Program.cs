var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (app.Environment.IsDevelopment()) app.MapGet("/", () => "Hello World!");
if (app.Environment.IsProduction()) app.MapGet("/", () => "Hello Dad!");

app.Run();

