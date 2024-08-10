using adessoTaskApi.Models.EntityModels;
using System.ComponentModel.DataAnnotations;

namespace adessoTaskApi.Models.DTOModels
{
    public class CountryDTO
    {
        public CountryDTO() { }
        public byte CountryId { get; set; }
        public string CountryName { get; set; }
        public List<TeamDTO> Teams { get; set; }
    }
}
