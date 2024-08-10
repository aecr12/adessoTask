using adessoTaskApi.Models.DTOModels;
using adessoTaskApi.Models.EntityModels;

namespace adessoTaskApi.Mappers
{
    public class TeamMapper
    {
        public static List<TeamDTO> entityToDtoList(List<Team> teams)
        {
            return teams.Select(c => EntityToDTO(c)).ToList();
        }
        public static List<Team> DtoToEntityList(List<TeamDTO> teams)
        {
            return teams.Select(c => DTOToEntity(c)).ToList();
        }
        public static TeamDTO EntityToDTO(Team team)
        {

            return new TeamDTO
            {
                TeamId = (byte)team.TeamId,
                TeamName = team.TeamName,
                CountryId = (byte) team.CountryId,

            };

        }
        public static Team DTOToEntity(TeamDTO team)
        {

            return new Team
            {
                TeamId = (byte)team.TeamId,
                TeamName = team.TeamName,
                CountryId = team.CountryId
            };

        }
    }
}

