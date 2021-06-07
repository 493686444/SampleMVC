namespace BLL.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _67d9h : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Year", c => c.Int());
            DropColumn("dbo.Users", "Yesr");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Yesr", c => c.Int());
            DropColumn("dbo.Users", "Year");
        }
    }
}
