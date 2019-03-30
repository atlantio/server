using Atlant.Bitcoin.Server.ExternalIntegration.Models;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Abstractions
{
    internal interface IBitcoinServerRequestBuilder
    {
        BitcoinServerRequestModel BuildSendToAddress(string address, double amount);
    }
}
