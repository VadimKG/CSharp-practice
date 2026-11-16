using Microsoft.Extensions.DependencyInjection;
using SmartHome.Application.Profiles;
using SmartHome.Application.Services;
using SmartHome.Core.Services;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace SmartHome.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddScoped<IDeviceService, DeviceService>();

            services.AddAutoMapper(cfg => { }, typeof(DeviceProfile));

            return services;
        }
    }
}
