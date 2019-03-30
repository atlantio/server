using System;
using Atlant.Bitcoin.Server.Domain.Abstractions.Core;

namespace Atlant.Bitcoin.Server.Domain.Entities
{
    public class Wallet : EntityBase<Guid>
    {
        public string Name { get; }

        public Wallet(Guid id, string name) : base(id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException(nameof(id));

            if (string.IsNullOrEmpty(name))
                throw new ArgumentException(nameof(name));

            Name = name;
        }
    }
}
