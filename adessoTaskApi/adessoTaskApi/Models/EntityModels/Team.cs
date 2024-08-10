using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace adessoTaskApi.Models.EntityModels
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        [Required]
        [MaxLength(255)]
        public string TeamName { get; set; }
        [Required]
        [ForeignKey("CountryFK")]
        public int CountryId { get; set; }

    }
}
