using Atlant.Bitcoin.Server.Settings.Abstractions;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace Atlant.Bitcoin.Server.Database.Migrations
{
    public static class DiConfigurationExtensions
    {
        public static IServiceCollection AddMigrationsServices(this IServiceCollection services)
        {
            services.AddSingleton<IConnectionStrings, ConnectionStrings>();

            var connectionStrings = services.BuildServiceProvider().GetRequiredService<IConnectionStrings>();

            services
                .AddFluentMigratorCore()
                .ConfigureRunner(builder =>
                {
                    builder
                        .AddSqlServer()
                        .WithGlobalConnectionString(connectionStrings.ConnectionString)
                        .ScanIn(typeof(Program).Assembly).For.Migrations();
                });

            return services;
        }
    }
}
