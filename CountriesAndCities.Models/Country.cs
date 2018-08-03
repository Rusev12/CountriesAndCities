namespace CountriesAndCities.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Country
    {
        public Country()
        {
            this.Cities = new HashSet<City>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(90)]
        [Index("IX_CountryName", 1, IsUnique = true)]
        public string LongName { get; set; }

        public string ShortName { get; set; }

        public int? CallingCode { get; set; }

        public string FlagUrl { get; set; }

        public virtual HashSet<City> Cities { get; set; }
    }
}
