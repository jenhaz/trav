namespace Trav.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Code = c.String(),
                        Visited = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trip",
                c => new
                    {
                        TripId = c.Int(nullable: false, identity: true),
                        CountryId = c.Int(nullable: false),
                        City = c.String(),
                        StartDate = c.String(),
                        EndDate = c.String(),
                    })
                .PrimaryKey(t => t.TripId)
                .ForeignKey("dbo.Country", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Trip", "CountryId", "dbo.Country");
            DropIndex("dbo.Trip", new[] { "CountryId" });
            DropTable("dbo.Trip");
            DropTable("dbo.Country");
        }
    }
}
