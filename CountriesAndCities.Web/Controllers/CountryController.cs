namespace CountriesAndCities.Web.Controllers
{
    using CountriesAndCities.Models;
    using CountriesAndCities.Services;
    using CountriesAndCities.Services.Contracts;
    using CountriesAndCities.Web.Models;
    using System.Web.Mvc;

    public class CountryController : Controller
    {
        private readonly IDataService service;

        public CountryController()
        {
            this.service = new DataService();
        }


        // GET: Country
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CountryBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return View(model);
            }
            var country = new Country()
            {
                LongName = model.LongName,
                ShortName = model.ShortName,
                CallingCode = model.CallingCode,
                FlagUrl = model.FlagUrl
            };

            try
            {

                this.service.CreateCountry(country);

            }
            catch (System.Exception)
            {
                this.ViewData["Error"] = "This country already exists!";
                return this.View(model);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}