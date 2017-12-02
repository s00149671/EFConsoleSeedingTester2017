namespace EFConsoleApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class all : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Member", "ClubEvent_EventID", c => c.Int());
            CreateIndex("dbo.Member", "ClubEvent_EventID");
            AddForeignKey("dbo.Member", "ClubEvent_EventID", "dbo.ClubEvent", "EventID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Member", "ClubEvent_EventID", "dbo.ClubEvent");
            DropIndex("dbo.Member", new[] { "ClubEvent_EventID" });
            DropColumn("dbo.Member", "ClubEvent_EventID");
        }
    }
}
