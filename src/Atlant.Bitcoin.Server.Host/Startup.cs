using Atlant.Bitcoin.Server.DataAccess.Sql;
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
            services.AddMvcCore();

            services.AddConfiguration();
            var connectionStrings = services.BuildServiceProvider().GetRequiredService<IConnectionStrings>();

            services
                .AddDataAccessServices(connectionStrings)
                .AddSqlRepositories();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc();
        }
    }
}
