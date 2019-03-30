using System.Net.Http;
using Atlant.Bitcoin.Server.ExternalIntegration.Abstractions;
using Atlant.Bitcoin.Server.ExternalIntegration.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Atlant.Bitcoin.Server.ExternalIntegration
{
    public static class DiConfigurationExtensions
    {
        public static IServiceCollection AddExtenralIntegrationServices(this IServiceCollection services)
        {
            services.AddTransient<HttpClient>();
            services.AddTransient<IPaymentExternalService, PaymentExternalService>();

            return services;
        }
    }
}
