using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Atlant.Bitcoin.Server.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                using (var host = CreateWebHost(args))
                    host.Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Environment.Exit(-1);
            }
        }

        public static IWebHost CreateWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(builder => builder.AddJsonFile("appsettings.json"))
                .UseStartup<Startup>()
                .Build();
    }
}
