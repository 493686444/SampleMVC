namespace BLL.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class last : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WeekDays", "Supervision_Id", "dbo.Supervisions");
            DropIndex("dbo.WeekDays", new[] { "Supervision_Id" });
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
            DropTable("dbo.Supervisions");
            DropTable("dbo.WeekDays");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.WeekDays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Selected = c.Boolean(nullable: false),
                        DayOfWeek = c.Int(nullable: false),
                        Supervision_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            DropForeignKey("dbo.Articles", "User_Id", "dbo.Users");
            DropIndex("dbo.Articles", new[] { "User_Id" });
            DropTable("dbo.Articles");
            CreateIndex("dbo.WeekDays", "Supervision_Id");
            AddForeignKey("dbo.WeekDays", "Supervision_Id", "dbo.Supervisions", "Id");
        }
    }
}
