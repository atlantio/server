using Atlant.Bitcoin.Server.DataAccess.Sql.Entities;
using Atlant.Bitcoin.Server.Domain.Entities;

namespace Atlant.Bitcoin.Server.DataAccess.Sql.Mappings
{
    internal static class WalletMappings
    {
        public static Wallet MapToWallet(this WalletEntity entity)
        {
            return new Wallet(entity.Id, entity.Name, entity.Balance);
        }

        public static WalletEntity MapToEntity(this Wallet wallet)
        {
            return new WalletEntity()
            {
                Balance = wallet.Balance,
                Id = wallet.Id,
                Name = wallet.Name
            };
        }
    }
}
