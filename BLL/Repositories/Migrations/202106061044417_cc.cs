namespace BLL.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Supervisions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Explain = c.String(),
                        Starting = c.DateTime(nullable: false),
                        Ended = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WeekDays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Selected = c.Boolean(nullable: false),
                        DayOfWeek = c.Int(nullable: false),
                        Supervision_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Supervisions", t => t.Supervision_Id)
                .Index(t => t.Supervision_Id);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                        Activated = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "Yesr", c => c.Int());
            AddColumn("dbo.Users", "Email_Id", c => c.Int());
            CreateIndex("dbo.Users", "Email_Id");
            AddForeignKey("dbo.Users", "Email_Id", "dbo.Emails", "Id");
            DropColumn("dbo.Users", "QQ");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "QQ", c => c.Int());
            DropForeignKey("dbo.Users", "Email_Id", "dbo.Emails");
            DropForeignKey("dbo.WeekDays", "Supervision_Id", "dbo.Supervisions");
            DropIndex("dbo.Users", new[] { "Email_Id" });
            DropIndex("dbo.WeekDays", new[] { "Supervision_Id" });
            DropColumn("dbo.Users", "Email_Id");
            DropColumn("dbo.Users", "Yesr");
            DropTable("dbo.Emails");
            DropTable("dbo.WeekDays");
            DropTable("dbo.Supervisions");
        }
    }
}
