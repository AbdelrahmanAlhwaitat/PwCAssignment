namespace PwCAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Sec : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "userName", c => c.String(nullable: false));
            AddColumn("dbo.Users", "password", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "firstName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "lastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "lastName", c => c.String());
            AlterColumn("dbo.Users", "firstName", c => c.String());
            DropColumn("dbo.Users", "password");
            DropColumn("dbo.Users", "userName");
        }
    }
}
