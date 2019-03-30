using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Atlant.Bitcoin.Server.ExternalIntegration.Abstractions;
using Atlant.Bitcoin.Server.ExternalIntegration.Abstractions.Internal;
using Atlant.Bitcoin.Server.ExternalIntegration.Models;
using Atlant.Bitcoin.Server.ExternalIntegration.Models.Internal;
using Atlant.Bitcoin.Server.ExternalIntegration.Models.Internal.RequestModels;
using Atlant.Bitcoin.Server.Settings.Abstractions;
using Newtonsoft.Json;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Services
{
    internal class HttpClientWrapper : IHttpClientWrapper
    {
        private readonly IBitcoinServerSettings _bitcoinServerSettings;
        private readonly HttpClient _client;

        public HttpClientWrapper(
            IBitcoinServerSettings bitcoinServerSettings,
            HttpClient client)
        {
            _bitcoinServerSettings =
                bitcoinServerSettings ?? throw new ArgumentNullException(nameof(bitcoinServerSettings));
            _client = client ?? throw new ArgumentNullException(nameof(client));

            InitializeClient();
        }

        public Task<HttpResponseMessage> SendAsync(string uri, BitcoinServerRequestModel content)
        {
            if (uri == null)
                throw new ArgumentNullException(nameof(uri));

            if (content == null)
                throw new ArgumentNullException(nameof(content));

            var stringContent = new StringContent(
                JsonConvert.SerializeObject(content),
                Encoding.UTF8,
                "application/json-rpc");

            return _client.PostAsync(uri, stringContent);
        }

        private void InitializeClient()
        {
            _client.BaseAddress = _bitcoinServerSettings.Uri;
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Basic",
                Convert.ToBase64String(
                    System.Text.ASCIIEncoding.ASCII.GetBytes(
                        string.Format("{0}:{1}", _bitcoinServerSettings.User, _bitcoinServerSettings.Password))));
        }
    }
}
