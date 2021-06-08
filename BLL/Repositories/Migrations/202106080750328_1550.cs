namespace BLL.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1550 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Emails", "Value", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Emails", "Value", c => c.Int(nullable: false));
        }
    }
}
