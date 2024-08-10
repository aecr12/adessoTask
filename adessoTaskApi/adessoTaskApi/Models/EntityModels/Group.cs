using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace adessoTaskApi.Models.EntityModels
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }
        [Required]
        public char GroupName { get; set; }
        public ICollection<Team> Teams { get; set; }
        [ForeignKey("GeneratorId")]
        public int GeneratorPersonId { get; set; }
        [ForeignKey("TeamId")]
        public int TeamId {  get; set; }    
    }
}
