using System;
using Atlant.Bitcoin.Server.Core;
using Atlant.Bitcoin.Server.ExternalIntegration.Models.Internal.ResponseModel;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Mappings
{
    internal static class BitcoinServerResponseModelMappings
    {
        public static OperationResult MapTOperationResult(this BitcoinServerResponseModel model)
        {
            if (model == null)
                throw new ArgumentNullException(nameof(model));

            bool success = model.Error == null;

            if (success)
                return new OperationResult(true, model.Result);

            return new OperationResult(false, model.Error?.Message);
        }
    }
}
