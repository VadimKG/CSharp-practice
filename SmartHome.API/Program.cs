using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Serilog;
using SmartHome.API.Data;
using SmartHome.API.Middlewares;
using SmartHome.API.Profiles;
using SmartHome.API.Repositories;
using SmartHome.API.Services;
using SmartHome.API.Validators;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, configuration) =>
{
    configuration
        .WriteTo.Console()
        .WriteTo.File("logs/log-.txt", rollingInterval: RollingInterval.Day);
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();

builder.Services.AddMemoryCache();

builder.Services.AddControllers();
builder.Services.AddHealthChecks()
                .AddDbContextCheck<AppDbContext>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining<CreateDeviceDtoValidator>();

builder.Services.AddScoped<IDeviceService, DeviceService>();

builder.Services.AddScoped<IDeviceRepository, DeviceRepository>();

builder.Services.AddAutoMapper(cfg => { }, typeof(DeviceProfile));

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.UseMiddleware<GlobalExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.MapHealthChecks("/health");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
