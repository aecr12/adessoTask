using adessoTaskApi.Models.EntityModels;
using System.ComponentModel.DataAnnotations;

namespace adessoTaskApi.Models.DTOModels
{
    public class PersonDTO
    {
        public PersonDTO() { }
        public int ID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
        public DateTime GenerationDate { get; set; }
    }
}
