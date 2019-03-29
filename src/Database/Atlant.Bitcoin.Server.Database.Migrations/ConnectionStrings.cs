using Atlant.Bitcoin.Server.Settings.Abstractions;
using Microsoft.Extensions.Configuration;

namespace Atlant.Bitcoin.Server.Database.Migrations
{
    internal class ConnectionStrings : IConnectionStrings
    {
        public string ConnectionString { get; private set; }

        public ConnectionStrings(IConfiguration configuration)
        {
            configuration.Bind(this, options => options.BindNonPublicProperties = true);
        }
    }
}
