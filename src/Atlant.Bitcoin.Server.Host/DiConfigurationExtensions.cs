﻿using Atlant.Bitcoin.Server.Settings.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace Atlant.Bitcoin.Server.Host
{
    public static class DiConfigurationExtensions
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services)
        {
            services.AddSingleton<IConnectionStrings, ConnectionStrings>();

            return services;
        }
    }
}
