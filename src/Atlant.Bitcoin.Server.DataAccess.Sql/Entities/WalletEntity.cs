using System;

namespace Atlant.Bitcoin.Server.DataAccess.Sql.Entities
{
    internal class WalletEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
    }
}
