using PokemonApi.Models;
using PokemonApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<PokemonDatabaseSettings>(
    builder.Configuration.GetSection("PokemonDatabase"));

// Create Singleton class for Pokemon/MongoDB service
builder.Services.AddSingleton<PokemonService>();


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseCors();

app.MapControllers();

app.Run();
