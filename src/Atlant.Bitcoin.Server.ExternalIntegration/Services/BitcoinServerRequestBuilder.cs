using System;
using System.Collections.Generic;
using Atlant.Bitcoin.Server.ExternalIntegration.Abstractions;
using Atlant.Bitcoin.Server.ExternalIntegration.Abstractions.Internal;
using Atlant.Bitcoin.Server.ExternalIntegration.Models;
using Atlant.Bitcoin.Server.ExternalIntegration.Models.Internal;
using Atlant.Bitcoin.Server.ExternalIntegration.Models.Internal.RequestModels;

namespace Atlant.Bitcoin.Server.ExternalIntegration.Services
{
    internal class BitcoinServerRequestBuilder : IBitcoinServerRequestBuilder
    {
        private BitcoinServerRequestModel Base => new BitcoinServerRequestModel()
        {
            JsonRpc = "1.0",
            Id = "curltest",
            Params = new List<string>()
        };

        public BitcoinServerRequestModel BuildSendToAddress(string address, double amount)
        {
            var request = Base;

            request.Method = "sendtoaddress";
            request.Params.Add(address);
            request.Params.Add(Convert.ToString(amount));

            return request;
        }
    }
}
