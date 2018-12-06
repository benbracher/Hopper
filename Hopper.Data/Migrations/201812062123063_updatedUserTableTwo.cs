namespace Hopper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedUserTableTwo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Connection",
                c => new
                    {
                        ConnectionId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        TransportId = c.Int(nullable: false),
                        RideId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ConnectionId)
                .ForeignKey("dbo.Ride", t => t.RideId, cascadeDelete: true)
                .ForeignKey("dbo.Transport", t => t.TransportId, cascadeDelete: true)
                .Index(t => t.TransportId)
                .Index(t => t.RideId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Connection", "TransportId", "dbo.Transport");
            DropForeignKey("dbo.Connection", "RideId", "dbo.Ride");
            DropIndex("dbo.Connection", new[] { "RideId" });
            DropIndex("dbo.Connection", new[] { "TransportId" });
            DropTable("dbo.Connection");
        }
    }
}
