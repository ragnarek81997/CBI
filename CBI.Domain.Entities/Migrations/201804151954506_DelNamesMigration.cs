namespace CBI.Domain.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DelNamesMigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "FirstName");
            DropColumn("dbo.Users", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "LastName", c => c.String(nullable: false, maxLength: 40));
            AddColumn("dbo.Users", "FirstName", c => c.String(nullable: false, maxLength: 40));
        }
    }
}
