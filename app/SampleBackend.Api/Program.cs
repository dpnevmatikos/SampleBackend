using SampleBackend.Config;
using SampleBackend.Data;
using SampleBackend.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services
    .AddConfig()
    .AddSampleBackendDbContext()
    .AddServices();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
