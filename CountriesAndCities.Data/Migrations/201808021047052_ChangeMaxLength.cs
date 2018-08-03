namespace CountriesAndCities.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMaxLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cities", "LongName", c => c.String(nullable: false, maxLength: 90));
            CreateIndex("dbo.Cities", "LongName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Cities", new[] { "LongName" });
            AlterColumn("dbo.Cities", "LongName", c => c.String(nullable: false));
        }
    }
}
