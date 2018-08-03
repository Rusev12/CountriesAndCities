namespace CountriesAndCities.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(90)]
        [Index("IX_LongName", 1, IsUnique = true)]        
        public string LongName { get; set; }

        public string ShortName { get; set; }

        public string Website { get; set; }

        public int? PostCode { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}
