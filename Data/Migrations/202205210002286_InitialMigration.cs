namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 250),
                        Director = c.String(maxLength: 30),
                        Producer = c.String(nullable: false, maxLength: 30),
                        Release_date = c.Int(nullable: false),
                        Running_time = c.Int(nullable: false),
                        Rt_score = c.Double(nullable: false),
                        LocationId = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedOn = c.DateTime(),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Climate = c.String(maxLength: 30),
                        Terrain = c.String(maxLength: 30),
                        Surface_water = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedOn = c.DateTime(),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Gender = c.String(maxLength: 15),
                        Age = c.Int(nullable: false),
                        Eye_color = c.String(maxLength: 15),
                        Hair_color = c.String(maxLength: 15),
                        Filmid = c.Int(nullable: false),
                        Locationid = c.Int(nullable: false),
                        CreatedBy = c.Int(nullable: false),
                        CreatedOn = c.DateTime(),
                        UpdatedBy = c.Int(nullable: false),
                        UpdatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Films", t => t.Filmid, cascadeDelete: true)
                .ForeignKey("dbo.Locations", t => t.Locationid, cascadeDelete: false)
                .Index(t => t.Filmid)
                .Index(t => t.Locationid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Films", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.People", "Locationid", "dbo.Locations");
            DropForeignKey("dbo.People", "Filmid", "dbo.Films");
            DropIndex("dbo.People", new[] { "Locationid" });
            DropIndex("dbo.People", new[] { "Filmid" });
            DropIndex("dbo.Films", new[] { "LocationId" });
            DropTable("dbo.People");
            DropTable("dbo.Locations");
            DropTable("dbo.Films");
        }
    }
}
