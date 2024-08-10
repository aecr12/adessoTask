using adessoTaskApi.Business;
using adessoTaskApi.Data;
using adessoTaskApi.Mappers;
using adessoTaskApi.Models.DTOModels;
using adessoTaskApi.Models.EntityModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace adessoTaskApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FixtureDrawController:ControllerBase
    {
        private readonly IDAO<Group> _groupDAO;
        private readonly IDAO<Country> _countryDAO;
        private readonly IDAO<Team> _teamDAO;
        private readonly IDAO<GeneratorPerson> _generatorPersonDAO;

        public FixtureDrawController(IDAO<Group> groupDAO, IDAO<Country> countryDAO, IDAO<Team> teamDAO, IDAO<GeneratorPerson> generatorPersonDAO)
        {
            _groupDAO = groupDAO;
            _countryDAO = countryDAO;
            _teamDAO = teamDAO;
            _generatorPersonDAO = generatorPersonDAO;
        }

        [HttpGet]
        public async Task<ActionResult> Draw(int GroupCount, string personName, string personSurname)
        {
            if(GroupCount !=8 && GroupCount!=4)
                return NotFound(); //yanlıs ınput hatası donecegız

            PersonDTO personDTO =await  GeneralBusiness.InitializePerson(_generatorPersonDAO, personName, personSurname );


            List<CountryDTO> countriesDTO = await GeneralBusiness.InitializeCountries(_countryDAO);
            List<TeamDTO> teamsDTO = await GeneralBusiness.InitializeTeams(_teamDAO, countriesDTO);



            List<GroupDTO> groupsDTO = GeneralBusiness.GenerateFixture(GroupCount, countriesDTO, personDTO);
            await GeneralBusiness.InsertGroup(_groupDAO, groupsDTO);

            var groups = groupsDTO.GroupBy(e=>e.GroupName).ToList();
            List<ResponseGroupDTO> returnVal = new List<ResponseGroupDTO>();
            foreach (IGrouping<char, GroupDTO> group in groups)
            {
                ResponseGroupDTO val =new ResponseGroupDTO();
                val.GroupName = group.Key;
                val.Teams = new List<ResponseTeamDTO>();
                foreach (var item in group)
                {
                    val.Teams.Add(new ResponseTeamDTO() { TeamName = item.TeamName });
                }
                returnVal.Add(val);
            }

            return Ok(returnVal);

        }

    }
}
