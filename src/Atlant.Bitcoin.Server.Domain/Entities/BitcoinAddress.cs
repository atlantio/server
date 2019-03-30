using System;
using Atlant.Bitcoin.Server.Domain.Abstractions.Core;

namespace Atlant.Bitcoin.Server.Domain.Entities
{
    public class BitcoinAddress : EntityBase<string>
    {
        public BitcoinAddress(string id) : base(id)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentException(nameof(id));
        }
    }
}
