using adessoTaskApi.Data;
using adessoTaskApi.Mappers;
using adessoTaskApi.Models.DTOModels;
using adessoTaskApi.Models.EntityModels;
using adessoTaskApi.Statics;
using System.Text.RegularExpressions;
using Group = adessoTaskApi.Models.EntityModels.Group;

namespace adessoTaskApi.Business
{
    public class GeneralBusiness
    {


        public static async Task<List<CountryDTO>> InitializeCountries(IDAO<Country> _country) {
            List<CountryDTO> countriesDTO = new List<CountryDTO>();
            List<Country> countries = await CountryBusiness.GetAllCountries(_country);
            if (countries.Count == 0)
            {
                countriesDTO = CountryBusiness.GenerateCountries();
                countries = CountryMapper.DtoToEntityList(countriesDTO);
                CountryBusiness.InsertAllCountries(_country, countries);
            }
            else
            {
                countriesDTO = CountryMapper.entityToDtoList(countries);
            }
            return countriesDTO;
        }

        public static async Task<List<TeamDTO>> InitializeTeams(IDAO<Team> _team, List<CountryDTO> countryDtos)
        {
            List<TeamDTO> teamsDTO = new List<TeamDTO>();
            List<Team> teams = await TeamBusiness.GetAllTeams(_team);
            if (countryDtos[0].Teams == null) { CountryBusiness.GenerateCountryTeams(countryDtos); }
            if (teams.Count == 0)
            {
                teamsDTO = TeamBusiness.GenerateCountryTeams(0, countryDtos);
                teams = TeamMapper.DtoToEntityList(teamsDTO);
                await TeamBusiness.InsertAllTeams(_team, teams);
            }
            else
            {
                teamsDTO = TeamMapper.entityToDtoList(teams);

            }
            return teamsDTO;
        }
        public static async Task<PersonDTO> InitializePerson(IDAO<GeneratorPerson> _generatorPerson, string name, string surname)
        {
            PersonDTO personDTO = new PersonDTO()
            {
                Name = name,
                Surname = surname     
            };
            GeneratorPerson person = await PersonBusiness.SelectPerson(_generatorPerson, name,surname);


            if (person == null)
            {
                await PersonBusiness.InsertPerson(_generatorPerson, name, surname);
                GeneratorPerson insertedPerson = await PersonBusiness.SelectPerson(_generatorPerson, name, surname);
                personDTO.ID = (byte)insertedPerson.GeneratorId;
            }

            return personDTO;
        }

        public static async Task InsertGroup(IDAO<Group> _group,List<GroupDTO> groupsDto)
        {

             List<Group> groupEntities = GroupMapper.DtoToEntityList(groupsDto);
             await GroupBusiness.InsertAllGroups(_group, groupEntities);

        }

        public static List<GroupDTO> GenerateFixture(int groupCount ,List<CountryDTO> countries, PersonDTO person)
        {
            Random random = new Random();
            List<GroupDTO> groups = new List<GroupDTO>();
            if (groupCount == 4)
            {
                foreach (var item in countries)
                {
                    int ascii = 65;
                    // Liste içinden rastgele bir eleman seç
                    TeamDTO randomTeam = new TeamDTO();
                    while (item.Teams.Count != 0)
                    {
                        randomTeam = item.Teams.OrderBy(x => random.Next()).FirstOrDefault();
                        groups.Add(new GroupDTO() { GroupName = (char)ascii, TeamId = randomTeam.TeamId,GeneratorPersonId=person.ID ,TeamName= randomTeam.TeamName});
                        ascii++;
                        item.Teams.Remove(randomTeam);
                    }

                }
            }
            else if (groupCount == 8)
            {
                foreach (var item in countries)
                {
                    int ascii = 65;
                    // Liste içinden rastgele bir eleman seç
                    TeamDTO randomTeam = new TeamDTO();
                    while (item.Teams.Count != 4)
                    {
                        randomTeam = item.Teams.OrderBy(x => random.Next()).FirstOrDefault();
                        groups.Add(new GroupDTO() { GroupName = (char)ascii, TeamId = randomTeam.TeamId, GeneratorPersonId = person.ID, TeamName = randomTeam.TeamName });
                        ascii++;
                        item.Teams.Remove(randomTeam);
                    }
                }
                foreach (var item in countries)
                {
                    int ascii = 65;
                    // Liste içinden rastgele bir eleman seç
                    TeamDTO randomTeam = new TeamDTO();
                    while (item.Teams.Count != 0)
                    {
                        randomTeam = item.Teams.OrderBy(x => random.Next()).FirstOrDefault();
                        groups.Add(new GroupDTO() { GroupName = (char)ascii, TeamId = randomTeam.TeamId, GeneratorPersonId = person.ID, TeamName = randomTeam.TeamName });
                        ascii++;
                        item.Teams.Remove(randomTeam);
                    }
                }
            }

            return groups;
        }
    }
}
