namespace BLL.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cccc : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Users", "Email_Id1", "dbo.Emails");
            DropIndex("dbo.Users", new[] { "Email_Id1" });
            RenameColumn(table: "dbo.Users", name: "Email_Id1", newName: "EmailId");
            AlterColumn("dbo.Users", "EmailId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "EmailId");
            AddForeignKey("dbo.Users", "EmailId", "dbo.Emails", "Id", cascadeDelete: true);
            DropColumn("dbo.Users", "Email_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Email_Id", c => c.Int(nullable: false));
            DropForeignKey("dbo.Users", "EmailId", "dbo.Emails");
            DropIndex("dbo.Users", new[] { "EmailId" });
            AlterColumn("dbo.Users", "EmailId", c => c.Int());
            RenameColumn(table: "dbo.Users", name: "EmailId", newName: "Email_Id1");
            CreateIndex("dbo.Users", "Email_Id1");
            AddForeignKey("dbo.Users", "Email_Id1", "dbo.Emails", "Id");
        }
    }
}
