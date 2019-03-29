using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;

namespace Atlant.Bitcoin.Server.Database.Migrations
{
    public static class DiConfigurationExtensions
    {
        public static IServiceCollection AddMigrationsServices(this IServiceCollection services)
        {
            services
                .AddFluentMigratorCore()
                .ConfigureRunner(builder =>
                {
                    builder
                        .AddSqlServer()
                        // TODO: remove hardcode
                        .WithGlobalConnectionString("Server=localhost;Database=Atlant;User Id=sa;Password = 12345;")
                        .ScanIn(typeof(Program).Assembly).For.Migrations();
                });

            return services;
        }
    }
}
