using ModularMonolith.Modules.Conferences.Api;
using ModularMonolith.Shared.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddConferencesModule();
builder.Services.AddInfrastructure();

var app = builder.Build();


app.UseConferencesModule();
app.UseInfrastructure();
app.MapControllers();

app.MapGet("/", () => "Modular Monolith API");

app.Run();
