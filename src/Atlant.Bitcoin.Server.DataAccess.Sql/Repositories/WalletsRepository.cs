using System.Collections.Generic;
using System.Threading.Tasks;
using Atlant.Bitcoin.Server.Domain.Entities;
using Atlant.Bitcoin.Server.Repositories;

namespace Atlant.Bitcoin.Server.DataAccess.Sql.Repositories
{
    internal class WalletsRepository : IWalletsRepository
    {
        public Task<IReadOnlyCollection<Wallet>> GetHotWalletsAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
