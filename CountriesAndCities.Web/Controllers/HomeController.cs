namespace CountriesAndCities.Web.Controllers
{
    using CountriesAndCities.Services;
    using CountriesAndCities.Services.Contracts;
    using CountriesAndCities.Web.Models;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : Controller
    {

        private readonly IDataService service;

        public HomeController()
        {
            this.service = new DataService();
        }


        [HttpGet]
        public ActionResult Index()
        {
            var countries = this.service.GetAllCountriesWithCities();

            var model = countries.Select(c => new HomeViewModel()
            {
                LongName = c.LongName,
                FlagUrl = c.FlagUrl,
                Cities = c.Cities
            }).ToList();

            return View(model);
        }
     
    }
}