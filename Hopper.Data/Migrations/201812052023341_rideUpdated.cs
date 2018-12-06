namespace Hopper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rideUpdated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Ride", "Address", c => c.String());
            AlterColumn("dbo.Ride", "City", c => c.String());
            AlterColumn("dbo.Ride", "State", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Ride", "State", c => c.String(nullable: false));
            AlterColumn("dbo.Ride", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Ride", "Address", c => c.String(nullable: false));
        }
    }
}
