using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace adessoTaskApi.Models.DTOModels
{
    public class TeamDTO
    {
        public TeamDTO() { }
        public TeamDTO(byte TeamId, string TeamName, byte CountryId) {
            this.TeamId = TeamId;
            this.TeamName = TeamName;
            this.CountryId = CountryId; 
        }
        public byte TeamId { get; set; }
        public string TeamName { get; set; }
        public byte CountryId { get; set; }
    }
    public class ResponseTeamDTO
    {
        public ResponseTeamDTO() { }

        public string TeamName { get; set; }
    }
}
