using System;
using System.Threading.Tasks;
using Atlant.Bitcoin.Server.ExternalIntegration.Abstractions;
using Atlant.Bitcoin.Server.ExternalIntegration.Models;
using Atlant.Bitcoin.Server.Settings.Abstractions;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Services
{
    internal class PaymentExternalService : IPaymentExternalService
    {
        private readonly IBitcoinServerRequestBuilder _bitcoinServerRequestBuilder;
        private readonly IHttpClientWrapper _client;

        public PaymentExternalService(
            IBitcoinServerRequestBuilder bitcoinServerRequestBuilder,
            IHttpClientWrapper client)
        {
            _bitcoinServerRequestBuilder =
                bitcoinServerRequestBuilder ?? throw new ArgumentNullException(nameof(bitcoinServerRequestBuilder));
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        //TODO: add response handling
        public async Task SendToAddress(string walletName, string toAddress, double amount)
        {
            var request = _bitcoinServerRequestBuilder.BuildSendToAddress(toAddress, amount);

            var response = await _client.SendAsync($"/wallet/{walletName}", request);
        }
    }
}
