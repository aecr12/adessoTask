using adessoTaskApi.Data;
using System.ComponentModel.DataAnnotations;

namespace adessoTaskApi.Models.EntityModels
{
    public class GeneratorPerson { 
        [Key]
        public int GeneratorId { get; set; }
        [Required]
        [MaxLength(255)]
        public string GeneratorName { get; set; }
        [Required]
        [MaxLength(255)]
        public string GeneratorSurname { get; set; }
        [Required]
        public DateTime GenerationDate { get; set; }
    }
}
