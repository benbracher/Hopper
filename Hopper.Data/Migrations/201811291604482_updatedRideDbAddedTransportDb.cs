namespace Hopper.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedRideDbAddedTransportDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transport",
                c => new
                    {
                        TransportId = c.Int(nullable: false, identity: true),
                        OwnerId = c.Guid(nullable: false),
                        TransportAnimal = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Color = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.TransportId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transport");
        }
    }
}
