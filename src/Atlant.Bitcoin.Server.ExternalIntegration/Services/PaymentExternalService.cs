using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Atlant.Bitcoin.Server.ExternalIntegration.Abstractions;
using Atlant.Bitcoin.Server.ExternalIntegration.Models.Abstractions;
using Atlant.Bitcoin.Server.Settings.Abstractions;
using Newtonsoft.Json;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Services
{
    internal class PaymentExternalService : IPaymentExternalService
    {
        private readonly IBitcoinServerSettings _bitcoinServerSettings;
        private readonly HttpClient _client;

        public PaymentExternalService(
            IBitcoinServerSettings bitcoinServerSettings,
            HttpClient client)
        {
            _bitcoinServerSettings =
                bitcoinServerSettings ?? throw new ArgumentNullException(nameof(bitcoinServerSettings));
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        //TODO: tmp solution just for testing, refactor after successfull testing
        public async Task SendToAddress(string walletName, string toAddress, double amount)
        {
            _client.BaseAddress = _bitcoinServerSettings.Uri;
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Basic",
                Convert.ToBase64String(
                    System.Text.ASCIIEncoding.ASCII.GetBytes(
                        string.Format("{0}:{1}", _bitcoinServerSettings.User, _bitcoinServerSettings.Password))));

            var request = new BitcoinServerModelBase();
            request.Method = "sendtoaddress";
            request.Params.Add(toAddress);
            request.Params.Add(Convert.ToString(amount));

            var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json-rpc");

            var response = await _client.PostAsync($"wallet/{walletName}", content);
        }
    }
}
