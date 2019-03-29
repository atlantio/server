using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

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
                .UseStartup<Startup>()
                .Build();
    }
}
