using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atlant.Bitcoin.Server.Domain.Entities;
using Atlant.Bitcoin.Server.Repositories;
using Atlant.Bitcoin.Server.DataAccess.Sql.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Atlant.Bitcoin.Server.DataAccess.Sql.Repositories
{
    internal class WalletsRepository : IWalletsRepository
    {
        private readonly AtlantContext _context;

        public WalletsRepository(AtlantContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IReadOnlyCollection<Wallet>> GetHotWalletsAsync()
        {
            var walletEntities = await _context.Wallets.ToListAsync();

            var wallets = walletEntities.Select(e => e.MapToWallet());

            return wallets.ToList();
        }
    }
}
