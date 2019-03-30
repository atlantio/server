using System.Collections.Generic;
using Newtonsoft.Json;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Models.Abstractions
{
    internal class BitcoinServerModelBase
    {
        [JsonProperty("jsonrpc")]
        public string JsonRpc { get; } = "1.0";

        [JsonProperty("id")]
        public string Id { get; } = "curltest";

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public ICollection<string> Params { get; set; } = new List<string>();
    }
}
