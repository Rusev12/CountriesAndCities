namespace CountriesAndCities.Web.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public class CityBindingModel
    {

        [Display(Name = "City name")]
        [Required]
        [MinLength(3)]
        public string LongName { get; set; }

        [Display(Name = "City abbreviation")]
        public string ShortName { get; set; }

        public int? PostCode { get; set; }

        public string Website { get; set; }

        [Required]
        [Display(Name = "Country")]
        public string SelectedCountryIso3 { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; }

    }
}