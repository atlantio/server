using Atlant.Bitcoin.Server.Application.Abstractions;
using Atlant.Bitcoin.Server.Contracts.RequestModels;
using Atlant.Bitcoin.Server.Controllers.Controllers.Abstractions.v1;
using Atlant.Bitcoin.Server.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Atlant.Bitcoin.Server.Controllers.Controllers
{
    public class PaymentsController : AtlantControllerBase
    {
        private readonly IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            _paymentService = paymentService ?? throw new ArgumentNullException(nameof(paymentService));
        }

        [HttpPost("money/send")]
        public async Task<IActionResult> SendToAddress([FromBody] SendMoneyRequestModel request)
        {
            // TODO: add generic solution
            if (request == null)
                return BadRequest();

            await _paymentService.TransferToAddress(request.RecipientAddress, request.Amount);

            return Ok();
        }
    }
}
