using System;
using System.Threading.Tasks;
using Atlant.Bitcoin.Server.Application.Abstractions;
using Atlant.Bitcoin.Server.Core;
using Atlant.Bitcoin.Server.ExternalIntegration.Abstractions;
using Atlant.Bitcoin.Server.Repositories;

namespace Atlant.Bitcoin.Server.Application.Services
{
    internal class PaymentService : IPaymentService
    {
        private readonly IWalletsRepository _walletsRepository;
        private readonly IWalletsService _walletsService;
        private readonly IPaymentExternalService _paymentExternalService;

        public PaymentService(
            IWalletsRepository walletsRepository,
            IWalletsService walletsService,
            IPaymentExternalService paymentExternalService)
        {
            _walletsRepository = walletsRepository ?? throw new ArgumentNullException(nameof(walletsRepository));
            _walletsService = walletsService ?? throw new ArgumentNullException(nameof(walletsService));
            _paymentExternalService =
                paymentExternalService ?? throw new ArgumentNullException(nameof(paymentExternalService));
        }

        public async Task<OperationResult> TransferToAddress(string to, double amount)
        {
            var hotWallet = await _walletsService.GetHotWalletAsync();

            var operatioResult = await _paymentExternalService.SendToAddress(hotWallet.Name, to, amount);

            // TODO: add consistency
            if (operatioResult.IsSucceeded)
            {
                hotWallet.SpendBalance(amount);
                await _walletsRepository.UpdateWalletAsync(hotWallet);
            }

            return operatioResult;
        }
    }
}
