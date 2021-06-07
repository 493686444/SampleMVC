namespace BLL.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1951 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "EmailId", "dbo.Emails");
            DropIndex("dbo.Users", new[] { "EmailId" });
            AlterColumn("dbo.Users", "EmailId", c => c.Int());
            CreateIndex("dbo.Users", "EmailId");
            AddForeignKey("dbo.Users", "EmailId", "dbo.Emails", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "EmailId", "dbo.Emails");
            DropIndex("dbo.Users", new[] { "EmailId" });
            AlterColumn("dbo.Users", "EmailId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "EmailId");
            AddForeignKey("dbo.Users", "EmailId", "dbo.Emails", "Id", cascadeDelete: true);
        }
    }
}
