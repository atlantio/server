using System.Threading.Tasks;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Abstractions
{
    public interface IPaymentExternalService
    {
        Task SendToAddress(string walletName, string toAddress, double amount);
    }
}
