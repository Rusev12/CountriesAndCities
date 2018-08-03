namespace CountriesAndCities.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingCountriesAndCities1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LongName = c.String(nullable: false),
                        ShortName = c.String(),
                        PostCode = c.Int(),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LongName = c.String(nullable: false),
                        ShortName = c.String(),
                        CallingCode = c.Int(),
                        FlagUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
        }
    }
}
