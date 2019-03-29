using Atlant.Bitcoin.Server.Contracts.RequestModels;
using Atlant.Bitcoin.Server.Controllers.Controllers.Abstractions.v1;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Atlant.Bitcoin.Server.Controllers.Controllers
{
    public class PaymentsController : AtlantControllerBase
    {
        [HttpPost("money/send")]
        public async Task<IActionResult> SendToAddress(SendMoneyRequestModel request)
        {
            // TODO: add generic solution
            if (request == null)
                return BadRequest();

            return Ok();
        }
    }
}
