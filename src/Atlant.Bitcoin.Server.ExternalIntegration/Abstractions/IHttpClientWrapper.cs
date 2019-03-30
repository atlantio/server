using System.Net.Http;
using System.Threading.Tasks;
using Atlant.Bitcoin.Server.ExternalIntegration.Models;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Abstractions
{
    internal interface IHttpClientWrapper
    {
        Task<HttpResponseMessage> SendAsync(string uri, BitcoinServerRequestModel content);
    }
}
