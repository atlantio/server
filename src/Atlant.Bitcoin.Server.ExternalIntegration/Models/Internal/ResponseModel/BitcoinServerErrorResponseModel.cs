using Newtonsoft.Json;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Models.Internal.ResponseModel
{
    internal class BitcoinServerErrorResponseModel
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
