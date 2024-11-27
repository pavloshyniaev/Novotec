using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Novotec.API.Interfaces;
using Novotec.API.Middlewares;
using Novotec.API.Repositories;
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
    config.UseMySql(builder.Configuration.GetConnectionString("pavlo"), 
        new MySqlServerVersion(new Version(8, 0, 27)));
    // config.UseSqlServer(builder.Configuration.GetConnectionString("novotec"));
});

var app = builder.Build();

app.UseMiddleware<ExceptionLoggingMiddleware>();

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