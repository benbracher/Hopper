namespace Hopper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedUserTables : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Connection", "OwnerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Connection", "OwnerId", c => c.Guid(nullable: false));
        }
    }
}
