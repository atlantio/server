using Atlant.Bitcoin.Server.DataAccess.Sql.Entities;
using Atlant.Bitcoin.Server.DataAccess.Sql.ModelBuilders;
using Microsoft.EntityFrameworkCore;

namespace Atlant.Bitcoin.Server.DataAccess.Sql
{
    internal class AtlantContext : DbContext
    {
        public DbSet<WalletEntity> Wallets { get; set; }

        public AtlantContext(DbContextOptions<AtlantContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            WalletModelBuilder.OnWalletModelCreating(modelBuilder);
        }
    }
}
