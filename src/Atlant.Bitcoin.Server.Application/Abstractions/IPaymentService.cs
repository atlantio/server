using System.Threading.Tasks;
using Atlant.Bitcoin.Server.Core;

namespace Atlant.Bitcoin.Server.Application.Abstractions
{
    public interface IPaymentService
    {
        Task<OperationResult> TransferToAddress(string to, double amount);
    }
}
