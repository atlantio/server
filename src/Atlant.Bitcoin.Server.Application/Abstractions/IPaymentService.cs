using System.Threading.Tasks;

namespace Atlant.Bitcoin.Server.Application.Abstractions
{
    public interface IPaymentService
    {
        Task TransferToAddress(string to, double amount);
    }
}
