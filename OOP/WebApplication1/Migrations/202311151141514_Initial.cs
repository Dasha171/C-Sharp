namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GuestbookEntries", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.GuestbookEntries", "Message", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GuestbookEntries", "Message", c => c.String());
            AlterColumn("dbo.GuestbookEntries", "Name", c => c.String());
        }
    }
}
