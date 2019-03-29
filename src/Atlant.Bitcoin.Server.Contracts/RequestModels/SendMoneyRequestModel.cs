using Newtonsoft.Json;

namespace Atlant.Bitcoin.Server.Contracts.RequestModels
{
    public class SendMoneyRequestModel
    {
        [JsonProperty("recipientAddress")]
        public string RecipientAddress { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }
    }
}
