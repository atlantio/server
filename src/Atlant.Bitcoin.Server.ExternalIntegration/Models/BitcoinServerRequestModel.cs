using System.Collections.Generic;
using Newtonsoft.Json;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Models
{
    internal class BitcoinServerRequestModel
    {
        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public ICollection<string> Params { get; set; }
    }
}
