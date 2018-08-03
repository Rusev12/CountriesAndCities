namespace CountriesAndCities.Services
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Mvc;
    using CountriesAndCities.Data;
    using CountriesAndCities.Models;
    using CountriesAndCities.Services.Contracts;

    public class DataService : IDataService
    {
        private readonly CountriesAndCitiesDbContext _db;

        public DataService()
        {
            this._db = new CountriesAndCitiesDbContext();
        }

        public void AddCityToCountry(City city, Country country)
        {
           this._db.Countries.Find(country.Id).Cities.Add(city);

            this._db.SaveChanges();
        }

        public void CreateCountry(Country country)
        {
            this._db.Countries.Add(country);
            this._db.SaveChanges();
        }

       
        public List<SelectListItem> GetAllValidCountries()
        {
            List<SelectListItem> allCountries = (from p in this._db.Countries.AsEnumerable()
                                                 select new SelectListItem
                                                 {
                                                     Text = p.LongName,
                                                     Value = p.Id.ToString()
                                                 }).ToList();

            allCountries.Insert(0, new SelectListItem { Text = "--Select Country--", Value = "" });

            return allCountries;
        }

        public Country GetSelectedCountry(int countryId)
        {
            var country = this._db.Countries.Find(countryId);

            return country;
        }

        public IEnumerable<Country> GetAllCountriesWithCities()
        {
            var countries = this._db.Countries
                .Include(c => c.Cities)
                .ToList();

            return countries;
        }

    }
}
