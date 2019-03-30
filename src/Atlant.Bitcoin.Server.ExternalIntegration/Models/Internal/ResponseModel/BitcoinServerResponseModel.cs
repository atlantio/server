using Newtonsoft.Json;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Models.Internal.ResponseModel
{
    internal class BitcoinServerResponseModel
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("error")]
        public BitcoinServerErrorResponseModel Error { get; set; }
    }
}
