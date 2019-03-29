using System;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Atlant.Bitcoin.Server.Database.Migrations
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var host = CreateHost())
                {
                    var runner = host.Services.GetRequiredService<IMigrationRunner>();

                    runner.MigrateUp();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Environment.Exit(-1);
            }
        }

        private static IHost CreateHost() =>
            new HostBuilder()
                .ConfigureServices(collection => collection.AddMigrationsServices())
                .Build();
    }
}
