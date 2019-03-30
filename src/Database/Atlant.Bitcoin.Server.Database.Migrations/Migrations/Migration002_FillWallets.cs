using System;
using System.Collections.Generic;
using FluentMigrator;

namespace Atlant.Bitcoin.Server.Database.Migrations.Migrations
{
    [Migration(2)]
    public class Migration002_FillWallets : ForwardOnlyMigration
    {
        public override void Up()
        {
            Insert
                .IntoTable("Wallets")
                .Row(new Dictionary<string, object>()
                {
                    { "Id", Guid.NewGuid() },
                    { "Name", "test1" }
                })
                .Row(new Dictionary<string, object>()
                {
                    { "Id", Guid.NewGuid() },
                    { "Name", "test2" }
                })
                .Row(new Dictionary<string, object>()
                {
                    { "Id", Guid.NewGuid() },
                    { "Name", "test3" }
                });
        }
    }
}
