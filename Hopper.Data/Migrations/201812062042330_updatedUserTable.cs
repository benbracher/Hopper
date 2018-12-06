namespace Hopper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ride", "RideCost", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ride", "RideCost");
        }
    }
}
