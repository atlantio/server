using Atlant.Bitcoin.Server.DataAccess.Sql.Entities;
using Microsoft.EntityFrameworkCore;

namespace Atlant.Bitcoin.Server.DataAccess.Sql.ModelBuilders
{
    internal static class WalletModelBuilder
    {
        public static void OnWalletModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<WalletEntity>()
                .ToTable("Wallets")
                .HasKey(entity => entity.Id).HasName("Id");
        }
    }
}
