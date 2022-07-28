namespace Gamer.gg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequirementsToGames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "Requirements", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Games", "Requirements");
        }
    }
}
