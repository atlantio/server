using System.Collections.Generic;
using System.Threading.Tasks;
using Atlant.Bitcoin.Server.Domain.Entities;

namespace Atlant.Bitcoin.Server.Repositories
{
    public interface IWalletsRepository
    {
        Task<IReadOnlyCollection<Wallet>> GetHotWalletsAsync();
    }
}
