using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartHome.Core.Repositories;
using SmartHome.Infrastructure.Data;
using SmartHome.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHome.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IDeviceRepository, DeviceRepository>();

            services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
            b => b.MigrationsAssembly("SmartHome.API")));

            return services;
        }
    }
}
