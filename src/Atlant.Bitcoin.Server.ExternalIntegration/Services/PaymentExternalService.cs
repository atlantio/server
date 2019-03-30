using System;
using System.Threading.Tasks;
using Atlant.Bitcoin.Server.Core;
using Atlant.Bitcoin.Server.ExternalIntegration.Abstractions;
using Atlant.Bitcoin.Server.ExternalIntegration.Abstractions.Internal;
using Atlant.Bitcoin.Server.ExternalIntegration.Mappings;
using Atlant.Bitcoin.Server.ExternalIntegration.Models.Internal.ResponseModel;
using Newtonsoft.Json;

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
        public async Task<OperationResult> SendToAddress(string walletName, string toAddress, double amount)
        {
            var request = _bitcoinServerRequestBuilder.BuildSendToAddress(toAddress, amount);

            var response = await _client.SendAsync($"/wallet/{walletName}", request);

            var content = await response.Content.ReadAsStringAsync();

            var serverResponse = JsonConvert.DeserializeObject<BitcoinServerResponseModel>(content);

            var operationResult = serverResponse.MapTOperationResult();

            return operationResult;
        }
    }
}
