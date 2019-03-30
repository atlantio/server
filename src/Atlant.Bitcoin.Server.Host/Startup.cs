using System;
using Atlant.Bitcoin.Server.Application;
using Atlant.Bitcoin.Server.DataAccess.Sql;
using Atlant.Bitcoin.Server.ExternalIntegration;
using Atlant.Bitcoin.Server.Settings.Abstractions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Atlant.Bitcoin.Server.Host
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvcCore()
                .AddJsonFormatters();

            services.AddHsts(options =>
            {
                options.IncludeSubDomains = true;
                options.MaxAge = TimeSpan.FromDays(10);
            });

            services.AddConfiguration();
            var connectionStrings = services.BuildServiceProvider().GetRequiredService<IConnectionStrings>();

            services
                .AddDataAccessServices(connectionStrings)
                .AddSqlRepositories()
                .AddExtenralIntegrationServices()
                .AddApplicationServices();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app
                .UseHsts()
                .UseHttpsRedirection()
                .UseMvc();
        }
    }
}
