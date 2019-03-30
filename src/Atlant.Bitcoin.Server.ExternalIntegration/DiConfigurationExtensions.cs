using System.Net.Http;
using Atlant.Bitcoin.Server.ExternalIntegration.Abstractions;
using Atlant.Bitcoin.Server.ExternalIntegration.Abstractions.Internal;
using Atlant.Bitcoin.Server.ExternalIntegration.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Atlant.Bitcoin.Server.ExternalIntegration
{
    public static class DiConfigurationExtensions
    {
        public static IServiceCollection AddExtenralIntegrationServices(this IServiceCollection services)
        {
            services.AddSingleton<HttpClient>();
            services.AddSingleton<IHttpClientWrapper, HttpClientWrapper>();
            services.AddSingleton<IBitcoinServerRequestBuilder, BitcoinServerRequestBuilder>();
            services.AddScoped<IPaymentExternalService, PaymentExternalService>();

            return services;
        }
    }
}
