namespace BLL.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _934 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "IconPath", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "IconPath");
        }
    }
}
