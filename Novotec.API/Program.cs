using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Novotec.API.Dto;
using Novotec.API.Interfaces;
using Novotec.API.Middlewares;
using Novotec.API.Repositories;
using NovotecDB;
using NovotecDB.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin", cors => cors
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod());
});

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Novotec API",
        Version = "v1"
    });
});

builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddDbContext<NovotecContext>(config =>
{
    config.UseSqlServer(builder.Configuration.GetConnectionString("novotec"), options =>
    {
        options.UseCompatibilityLevel(110);
    });
});
builder.Services.AddDbContext<AgrarwareConnectorContext>(config =>
{
    config.UseSqlServer(builder.Configuration.GetConnectionString("agrarwareConnector"));
});
var app = builder.Build();

app.UseMiddleware<ExceptionLoggingMiddleware>();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<AgrarwareConnectorContext>();
    dbContext.Database.Migrate();
}

if (app.Environment.IsDevelopment() || app.Environment.IsEnvironment("Local"))
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Novotec API v1");
    });
}

app.UseCors("AllowAnyOrigin");

app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();