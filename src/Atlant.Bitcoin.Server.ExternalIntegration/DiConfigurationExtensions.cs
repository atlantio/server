﻿using System.Net.Http;
using Atlant.Bitcoin.Server.ExternalIntegration.Abstractions;
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
            services.AddScoped<IPaymentExternalService, PaymentExternalService>();

            return services;
        }
    }
}
