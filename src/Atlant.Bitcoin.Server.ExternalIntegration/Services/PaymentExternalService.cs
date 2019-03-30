using System;
using System.Threading.Tasks;
using Atlant.Bitcoin.Server.ExternalIntegration.Abstractions;
using Atlant.Bitcoin.Server.ExternalIntegration.Models;
using Atlant.Bitcoin.Server.Settings.Abstractions;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Services
{
    internal class PaymentExternalService : IPaymentExternalService
    {
        private readonly IBitcoinServerSettings _bitcoinServerSettings;
        private readonly IHttpClientWrapper _client;

        public PaymentExternalService(
            IBitcoinServerSettings bitcoinServerSettings,
            IHttpClientWrapper client)
        {
            _bitcoinServerSettings =
                bitcoinServerSettings ?? throw new ArgumentNullException(nameof(bitcoinServerSettings));
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        //TODO: tmp solution just for testing, refactor after successfull testing
        public async Task SendToAddress(string walletName, string toAddress, double amount)
        {
            var request = new BitcoinServerRequestModel();
            request.Method = "sendtoaddress";
            request.Params.Add(toAddress);
            request.Params.Add(Convert.ToString(amount));

            var response = await _client.SendAsync($"wallet/{walletName}", request);
        }
    }
}
