using System.Threading.Tasks;
using Atlant.Bitcoin.Server.Domain.Entities;

namespace Atlant.Bitcoin.Server.Application.Abstractions
{
    public interface IPaymentService
    {
        Task TransferToAddress(BitcoinAddress to, double amount);
    }
}
