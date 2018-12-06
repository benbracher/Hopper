namespace Hopper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedDt : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Ride", "DistanceTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ride", "DistanceTime", c => c.DateTime(nullable: false));
        }
    }
}
