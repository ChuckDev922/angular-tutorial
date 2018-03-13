namespace ElementsAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Elements",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AtomicNumber = c.Int(nullable: false),
                        AtomicWeight = c.Single(nullable: false),
                        Name = c.String(maxLength: 128),
                        Symbol = c.String(),
                        MeltingPoint = c.Single(nullable: false),
                        BoilingPoint = c.Single(nullable: false),
                        Density = c.Single(nullable: false),
                        EarthCrustPerCentage = c.Single(nullable: false),
                        Discovered = c.String(),
                        Group = c.Int(nullable: false),
                        ElectronConfiguration = c.String(),
                        IonizationEnergy = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Name, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Elements", new[] { "Name" });
            DropTable("dbo.Elements");
        }
    }
}
