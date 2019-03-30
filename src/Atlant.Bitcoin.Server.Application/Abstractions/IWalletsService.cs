using System.Threading.Tasks;
using Atlant.Bitcoin.Server.Domain.Entities;

namespace Atlant.Bitcoin.Server.Application.Abstractions
{
    public interface IWalletsService
    {
        Task<Wallet> GetHotWalletAsync();
    }
}
