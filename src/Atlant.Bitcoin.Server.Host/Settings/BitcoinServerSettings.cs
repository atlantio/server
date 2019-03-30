using System;
using Atlant.Bitcoin.Server.Settings.Abstractions;
using Microsoft.Extensions.Configuration;

namespace Atlant.Bitcoin.Server.Host.Settings
{
    internal class BitcoinServerSettings : IBitcoinServerSettings
    {
        public Uri Uri { get; private set; }
        public string User { get; private set; }
        public string Password { get; private set; }

        public BitcoinServerSettings(IConfiguration configuration)
        {
            configuration
                .GetSection("BitcoinServer")
                .Bind(this, options => options.BindNonPublicProperties = true);
        }
    }
}
