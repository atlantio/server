using Atlant.Bitcoin.Server.Application.Abstractions;
using Atlant.Bitcoin.Server.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Atlant.Bitcoin.Server.Application
{
    public static class DiConfigurationExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IWalletsService, WalletsService>();
            services.AddScoped<IPaymentService, PaymentService>();

            return services;
        }
    }
}
