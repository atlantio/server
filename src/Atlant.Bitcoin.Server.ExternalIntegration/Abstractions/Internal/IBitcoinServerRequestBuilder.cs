using Atlant.Bitcoin.Server.ExternalIntegration.Models.Internal.RequestModels;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Abstractions.Internal
{
    internal interface IBitcoinServerRequestBuilder
    {
        BitcoinServerRequestModel BuildSendToAddress(string address, double amount);
    }
}
