namespace CountriesAndCities.Web.Controllers
{
    using CountriesAndCities.Models;
    using CountriesAndCities.Services;
    using CountriesAndCities.Services.Contracts;
    using CountriesAndCities.Web.Models;
    using System;
    using System.Web.Mvc;

    public class CityController : Controller
    {
        private readonly IDataService service;

        public CityController()
        {
            this.service = new DataService();
        }


        // GET: City
        [HttpGet]
        public ActionResult Add()
        {
            var countryList  = this.service.GetAllValidCountries();
            var model = new CityBindingModel()
            {
                Countries = countryList
            };

            return View(model);
        }


        [HttpPost]
        public ActionResult Add(CityBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Add();
            }

            var countryId = int.Parse(model.SelectedCountryIso3);

            var country = this.service.GetSelectedCountry(countryId);

            var city = new City()
            {
                Country = country,
                CountryId = countryId,
                LongName = model.LongName,
                ShortName = model.ShortName,
                PostCode = model.PostCode,
                Website = model.Website
            };

            if (country.LongName == city.LongName)
            {
                this.TempData["Error"] = "Error: Equal names!";
                return RedirectToAction("Add" , "City");
            }

            try
            {
                this.service.AddCityToCountry(city, country);
            }
            catch (Exception)
            {
                this.TempData["Error"] = "This city already exists!";
                return this.RedirectToAction("Add" , "City");
            }

            return RedirectToAction("Index", "Home");
        }

       
    }
}