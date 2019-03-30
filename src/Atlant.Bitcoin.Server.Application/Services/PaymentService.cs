using System;
using System.Threading.Tasks;
using Atlant.Bitcoin.Server.Application.Abstractions;
using Atlant.Bitcoin.Server.Domain.Entities;

namespace Atlant.Bitcoin.Server.Application.Services
{
    internal class PaymentService : IPaymentService
    {
        private readonly IWalletsService _walletsService;

        public PaymentService(IWalletsService walletsService)
        {
            _walletsService = walletsService ?? throw new ArgumentNullException(nameof(walletsService));
        }

        public async Task TransferToAddress(BitcoinAddress to, double amount)
        {
            var hotWallet = await _walletsService.GetHotWalletAsync();

            // TODO: add transfering logic
        }
    }
}
