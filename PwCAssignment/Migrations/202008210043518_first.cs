namespace PwCAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Complaints",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        userId = c.Int(nullable: false),
                        status = c.Int(nullable: false),
                        complaintletter = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.userId, cascadeDelete: true)
                .Index(t => t.userId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        gender = c.Int(nullable: false),
                        dob = c.DateTime(nullable: false),
                        userType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Complaints", "userId", "dbo.Users");
            DropIndex("dbo.Complaints", new[] { "userId" });
            DropTable("dbo.Users");
            DropTable("dbo.Complaints");
        }
    }
}
