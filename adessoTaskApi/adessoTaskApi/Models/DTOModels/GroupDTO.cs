using adessoTaskApi.Models.EntityModels;
using System.ComponentModel.DataAnnotations;

namespace adessoTaskApi.Models.DTOModels
{
    public class GroupDTO
    {
        public GroupDTO() { }
        public byte GroupId { get; set; }
        public char GroupName { get; set; }
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public List<Team> Teams { get; set; }
        public int GeneratorPersonId { get; set; }
    }

    public class ResponseGroupDTO
    {
        public ResponseGroupDTO() { }
        public char GroupName { get; set; }
        public List<ResponseTeamDTO> Teams { get; set; }
    }
}
