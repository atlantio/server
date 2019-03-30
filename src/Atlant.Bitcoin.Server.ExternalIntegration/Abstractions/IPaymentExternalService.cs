using System.Threading.Tasks;
using Atlant.Bitcoin.Server.Core;
using Atlant.Bitcoin.Server.ExternalIntegration.Models;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Abstractions
{
    public interface IPaymentExternalService
    {
        Task<OperationResult> SendToAddress(string walletName, string toAddress, double amount);
    }
}
