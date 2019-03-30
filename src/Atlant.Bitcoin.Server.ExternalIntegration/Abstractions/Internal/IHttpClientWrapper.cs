using System.Net.Http;
using System.Threading.Tasks;
using Atlant.Bitcoin.Server.ExternalIntegration.Models.Internal.RequestModels;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Abstractions.Internal
{
    internal interface IHttpClientWrapper
    {
        Task<HttpResponseMessage> SendAsync(string uri, BitcoinServerRequestModel content);
    }
}
