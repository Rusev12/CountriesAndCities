namespace CountriesAndCities.Data
{
    using System.Data.Entity;
    using CountriesAndCities.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class CountriesAndCitiesDbContext : IdentityDbContext<User>
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }

        public CountriesAndCitiesDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static CountriesAndCitiesDbContext Create()
        {
            return new CountriesAndCitiesDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            
            base.OnModelCreating(builder);
        }
    }
}
