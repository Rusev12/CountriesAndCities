namespace CountriesAndCities.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddWebSitePropetry : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cities", "Website", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cities", "Website");
        }
    }
}
