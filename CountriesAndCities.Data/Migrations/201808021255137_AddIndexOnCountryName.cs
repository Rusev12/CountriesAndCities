namespace CountriesAndCities.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIndexOnCountryName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Countries", "LongName", c => c.String(nullable: false, maxLength: 90));
            CreateIndex("dbo.Countries", "LongName", unique: true, name: "IX_CountryName");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Countries", "IX_CountryName");
            AlterColumn("dbo.Countries", "LongName", c => c.String(nullable: false));
        }
    }
}
