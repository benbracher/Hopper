namespace Hopper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedDtTwo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ride", "DistanceTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ride", "DistanceTime");
        }
    }
}
