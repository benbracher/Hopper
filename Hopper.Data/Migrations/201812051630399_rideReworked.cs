namespace Hopper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rideReworked : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ride", "Address", c => c.String(nullable: false));
            AddColumn("dbo.Ride", "City", c => c.String(nullable: false));
            AddColumn("dbo.Ride", "State", c => c.String(nullable: false));
            DropColumn("dbo.Ride", "StartLocation");
            DropColumn("dbo.Ride", "EndLocation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ride", "EndLocation", c => c.String(nullable: false));
            AddColumn("dbo.Ride", "StartLocation", c => c.String(nullable: false));
            DropColumn("dbo.Ride", "State");
            DropColumn("dbo.Ride", "City");
            DropColumn("dbo.Ride", "Address");
        }
    }
}
