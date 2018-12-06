namespace Hopper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ride", "OwnerId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ride", "OwnerId");
        }
    }
}
