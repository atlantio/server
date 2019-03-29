using FluentMigrator;

namespace Atlant.Bitcoin.Server.Database.Migrations.Migrations
{
    [Migration(1)]
    public class Migration001_CreateWalletsTable : ForwardOnlyMigration
    {
        public override void Up()
        {
            Create.Table("Wallets")
                .WithColumn("Id").AsGuid().PrimaryKey()
                .WithColumn("Name").AsString().NotNullable().Unique()
                .WithColumn("Balance").AsDouble().NotNullable();
        }
    }
}
