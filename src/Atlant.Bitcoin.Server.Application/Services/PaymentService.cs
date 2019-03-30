using System;
using System.Threading.Tasks;
using Atlant.Bitcoin.Server.Application.Abstractions;
using Atlant.Bitcoin.Server.Domain.Entities;
using Atlant.Bitcoin.Server.ExternalIntegration.Abstractions;

namespace Atlant.Bitcoin.Server.Application.Services
{
    internal class PaymentService : IPaymentService
    {
        private readonly IWalletsService _walletsService;
        private readonly IPaymentExternalService _paymentExternalService;

        public PaymentService(
            IWalletsService walletsService,
            IPaymentExternalService paymentExternalService)
        {
            _walletsService = walletsService ?? throw new ArgumentNullException(nameof(walletsService));
            _paymentExternalService =
                paymentExternalService ?? throw new ArgumentNullException(nameof(paymentExternalService));
        }

        public async Task TransferToAddress(string to, double amount)
        {
            var hotWallet = await _walletsService.GetHotWalletAsync();

            await _paymentExternalService.SendToAddress(hotWallet.Name, to, amount);
        }
    }
}
