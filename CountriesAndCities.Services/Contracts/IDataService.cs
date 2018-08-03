namespace CountriesAndCities.Services.Contracts
{
    using CountriesAndCities.Models;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public interface IDataService
    {
        void CreateCountry(Country country);

        List<SelectListItem> GetAllValidCountries();

        Country GetSelectedCountry(int countryId);

        void AddCityToCountry(City city, Country country);

        IEnumerable<Country> GetAllCountriesWithCities();
    }
}
