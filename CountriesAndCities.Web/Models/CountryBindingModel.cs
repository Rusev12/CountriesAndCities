namespace CountriesAndCities.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class CountryBindingModel
    {
        [Required]
        [MinLength(3)]
        [Display(Name = "Country name")]
        public string LongName { get; set; }


        [Display(Name = "Country Name Abbreviation")]
        public string ShortName { get; set; }

        public int? CallingCode { get; set; }

        public string FlagUrl { get; set; }
    }
}