namespace Hopper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rideUpdated1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ride", "StartAddress", c => c.String());
            AddColumn("dbo.Ride", "StartCity", c => c.String());
            AddColumn("dbo.Ride", "StartState", c => c.String());
            AddColumn("dbo.Ride", "EndAddress", c => c.String());
            AddColumn("dbo.Ride", "EndCity", c => c.String());
            AddColumn("dbo.Ride", "EndState", c => c.String());
            DropColumn("dbo.Ride", "Address");
            DropColumn("dbo.Ride", "City");
            DropColumn("dbo.Ride", "State");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ride", "State", c => c.String());
            AddColumn("dbo.Ride", "City", c => c.String());
            AddColumn("dbo.Ride", "Address", c => c.String());
            DropColumn("dbo.Ride", "EndState");
            DropColumn("dbo.Ride", "EndCity");
            DropColumn("dbo.Ride", "EndAddress");
            DropColumn("dbo.Ride", "StartState");
            DropColumn("dbo.Ride", "StartCity");
            DropColumn("dbo.Ride", "StartAddress");
        }
    }
}
