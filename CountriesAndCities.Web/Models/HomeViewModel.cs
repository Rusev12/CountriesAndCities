namespace CountriesAndCities.Web.Models
{
    using CountriesAndCities.Models;
    using System.Collections.Generic;

    public class HomeViewModel
    {
        public string LongName { get; set; }

        public string FlagUrl { get; set; }

        public HashSet<City> Cities { get; set; }
    }
}