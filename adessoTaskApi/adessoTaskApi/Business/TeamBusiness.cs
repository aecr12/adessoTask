using adessoTaskApi.Data;
using adessoTaskApi.Models.DTOModels;
using adessoTaskApi.Models.EntityModels;

namespace adessoTaskApi.Business
{
    public class TeamBusiness
    {
        public static List<TeamDTO> GenerateTeams(List<string> TeamsName, byte _GroupId, byte _CountryId)
        {
            List<TeamDTO> teams = new List<TeamDTO>();    
            foreach (var teamName in TeamsName)
            {
                TeamDTO teamDTO = new TeamDTO() {
                    TeamName = teamName,
                    CountryId = _CountryId
                };
                teams.Add(teamDTO);
            }

            return teams;
        }
        public static List<TeamDTO> GenerateCountryTeams(byte _GroupId, List<CountryDTO> Country)
        {
            List<TeamDTO> teams = new List<TeamDTO>();
            foreach(var country in Country)
            {
                foreach (var team in country.Teams)
                {
                    teams.Add(team);
                }
            }

            return teams;
        }



        public static async Task<List<Team>> GetAllTeams(IDAO<Team> _team)
        {
            List<Team> teamsEntity = new List<Team>();
            try
            {
                teamsEntity = (List<Team>)await _team.GetAllAsync();
            }
            catch (Exception e)
            {
                throw;
            }
            return teamsEntity;

        }

        public static async Task InsertAllTeams(IDAO<Team> _team, List<Team> teams)
        {
            try
            {
                await _team.CreateAsync(teams);
            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}
