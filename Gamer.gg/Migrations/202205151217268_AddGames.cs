﻿namespace Gamer.gg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGames : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Image = c.String(),
                        Trailer = c.String(),
                        Description = c.String(),
                        genre = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}
