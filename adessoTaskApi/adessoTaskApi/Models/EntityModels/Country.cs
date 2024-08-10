using System.ComponentModel.DataAnnotations;

namespace adessoTaskApi.Models.EntityModels
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        [Required]
        [MaxLength(255)]
        public string CountryName { get; set; }
        public ICollection<Team> Teams { get; set; }

    }
}
