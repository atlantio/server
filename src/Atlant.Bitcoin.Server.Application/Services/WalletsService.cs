using System;
using System.Linq;
using System.Threading.Tasks;
using Atlant.Bitcoin.Server.Application.Abstractions;
using Atlant.Bitcoin.Server.Domain.Entities;
using Atlant.Bitcoin.Server.Repositories;

namespace Atlant.Bitcoin.Server.Application.Services
{
    internal class WalletsService : IWalletsService
    {
        private readonly IWalletsRepository _walletsRepository;

        public WalletsService(IWalletsRepository walletsRepository)
        {
            _walletsRepository = walletsRepository ?? throw new ArgumentNullException(nameof(walletsRepository));
        }

        public async Task<Wallet> GetHotWalletAsync()
        {
            var wallets = await _walletsRepository.GetHotWalletsAsync();

            // TODO: change to more meaningfull algo
            return wallets.First();
        }
    }
}
