﻿using System;
using Atlant.Bitcoin.Server.DataAccess.Sql.Repositories;
using Atlant.Bitcoin.Server.Repositories;
using Atlant.Bitcoin.Server.Settings.Abstractions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Atlant.Bitcoin.Server.DataAccess.Sql
{
    public static class DiConfigurationExtensions
    {
        public static IServiceCollection AddDataAccessServices(
            this IServiceCollection services,
            IConnectionStrings connectionStrings)
        {
            if (connectionStrings == null)
                throw new ArgumentNullException(nameof(connectionStrings));

            services.AddDbContext<AtlantContext>(builder =>
            {
                builder.UseSqlServer(connectionStrings.ConnectionString);

            });

            return services;
        }

        public static IServiceCollection AddSqlRepositories(this IServiceCollection services)
        {
            services.AddScoped<IWalletsRepository, WalletsRepository>();

            return services;
        }
    }
}
