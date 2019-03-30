using System;
using Atlant.Bitcoin.Server.Domain.Abstractions.Core;

namespace Atlant.Bitcoin.Server.Domain.Entities
{
    public class Wallet : EntityBase<Guid>
    {
        public string Name { get; }
        public double Balance { get; private set; }

        public Wallet(
            Guid id,
            string name,
            double balance) : base(id)
        {
            if (id == Guid.Empty)
                throw new ArgumentException(nameof(id));

            if (string.IsNullOrEmpty(name))
                throw new ArgumentException(nameof(name));

            if (balance < 0)
                throw new ArgumentException(nameof(balance));

            Name = name;
            Balance = balance;
        }

        public void SpendBalance(double amount)
        {
            if (Balance - amount < 0)
                throw new InvalidOperationException("Balance cannot be less than 0");

            Balance -= amount;
        }
    }
}
