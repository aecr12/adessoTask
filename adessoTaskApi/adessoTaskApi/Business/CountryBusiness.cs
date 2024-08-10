using adessoTaskApi.Data;
using adessoTaskApi.Models.DTOModels;
using adessoTaskApi.Models.EntityModels;
using adessoTaskApi.Statics;

namespace adessoTaskApi.Business
{
    public class CountryBusiness
    {
        public static List<CountryDTO> GenerateCountries()
        {
            return new List<CountryDTO> {
                GenerateCountry("Türkiye",1,new List<string>(){"Adesso İstanbul", "Adesso Ankara", "Adesso İzmir", "Adesso Antalya"}),
                GenerateCountry("Almanya",2,new List<string>(){ "Adesso Berlin", "Adesso Frankfurt", "Adesso Münih", "Adesso Dortmund"}),
                GenerateCountry("Fransa",3,new List<string>(){ "Adesso Paris", "Adesso Marsilya", "Adesso Nice", "Adesso Lyon"}),
                GenerateCountry("Hollanda",4,new List<string>(){ "Adesso Amsterdam"," Adesso Rotterdam", "Adesso Lahey", "Adesso Eindhoven"}),
                GenerateCountry("Portekiz",5,new List<string>(){ "Adesso Lisbon", "Adesso Porto", "Adesso Braga", "Adesso Coimbra"}),
                GenerateCountry("İtalya",6,new List<string>(){ "Adesso Roma", "Adesso Milano", "Adesso Venedik"," Adesso Napoli"}),
                GenerateCountry("İspanya",7,new List<string>(){"Adesso Sevilla", "Adesso Madrid", "Adesso Barselona", "Adesso Granada"}),
                GenerateCountry("Belçika",8,new List<string>(){"Adesso Brüksel", "Adesso Brugge"," Adesso Gent", "Adesso Anvers" })
          };
        }
        public static CountryDTO GenerateCountry(string countryName, byte countryId, List<string> teamNames)
        {
            return new CountryDTO()
            {
                CountryName = countryName,
                CountryId = countryId,
                Teams = TeamBusiness.GenerateTeams(teamNames, 0, countryId)
            };
        }
        public static void GenerateCountryTeams(List<CountryDTO> countries)
        {
            foreach (var country in countries)
            {
                country.Teams = new List<TeamDTO>();
                switch (country.CountryName) {
                    case CountriesConst.Turkiye:
                        country.Teams.Add(new TeamDTO() { TeamId = 1, TeamName = TeamsConst.AdessoIstanbul, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 2, TeamName = TeamsConst.AdessoAnkara, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 3, TeamName = TeamsConst.AdessoIzmir, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 4, TeamName = TeamsConst.AdessoAntalya, CountryId = country.CountryId });
                        break;

                    case CountriesConst.Almanya:
                        country.Teams.Add(new TeamDTO() { TeamId = 5, TeamName = TeamsConst.AdessoBerlin, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 6, TeamName = TeamsConst.AdessoFrankfurt, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 7, TeamName = TeamsConst.AdessoMunih, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 8, TeamName = TeamsConst.AdessoDortmund, CountryId = country.CountryId });
                        break;

                    case CountriesConst.Fransa:
                        country.Teams.Add(new TeamDTO() { TeamId = 9, TeamName = TeamsConst.AdessoParis, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 10, TeamName = TeamsConst.AdessoMarsilya, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 11, TeamName = TeamsConst.AdessoNice, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 12, TeamName = TeamsConst.AdessoLyon, CountryId = country.CountryId });
                        break;

                    case CountriesConst.Hollanda:
                        country.Teams.Add(new TeamDTO() { TeamId = 13, TeamName = TeamsConst.AdessoAmsterdam, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 14, TeamName = TeamsConst.AdessoRotterdam, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 15, TeamName = TeamsConst.AdessoLahey, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 16, TeamName = TeamsConst.AdessoEindhoven, CountryId = country.CountryId });
                        break;

                    case CountriesConst.Portekiz:
                        country.Teams.Add(new TeamDTO() { TeamId = 17, TeamName = TeamsConst.AdessoLisbon, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 18, TeamName = TeamsConst.AdessoPorto, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 19, TeamName = TeamsConst.AdessoBraga, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 20, TeamName = TeamsConst.AdessoCoimbra, CountryId = country.CountryId });
                        break;

                    case CountriesConst.Italya:
                        country.Teams.Add(new TeamDTO() { TeamId = 21, TeamName = TeamsConst.AdessoRoma, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 22, TeamName = TeamsConst.AdessoMilano, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 23, TeamName = TeamsConst.AdessoVenedik, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 24, TeamName = TeamsConst.AdessoNapoli, CountryId = country.CountryId });
                        break;

                    case CountriesConst.Ispanya:
                        country.Teams.Add(new TeamDTO() { TeamId = 25, TeamName = TeamsConst.AdessoSevilla, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 26, TeamName = TeamsConst.AdessoMadrid, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 27, TeamName = TeamsConst.AdessoBarselona, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 28, TeamName = TeamsConst.AdessoGranada, CountryId = country.CountryId });
                        break;

                    case CountriesConst.Belcika:
                        country.Teams.Add(new TeamDTO() { TeamId = 29, TeamName = TeamsConst.AdessoBruksel, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 30, TeamName = TeamsConst.AdessoBrugge, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 31, TeamName = TeamsConst.AdessoGent, CountryId = country.CountryId });
                        country.Teams.Add(new TeamDTO() { TeamId = 32, TeamName = TeamsConst.AdessoAnvers, CountryId = country.CountryId });
                        break;

                }
            }
        }

        public static async Task<List<Country>> GetAllCountries(IDAO<Country> _country)
        {
            List<Country> countriesEntity = new List<Country>();
            try
            {
                countriesEntity = (List<Country>)await _country.GetAllAsync();
            }
            catch (Exception e)
            {
                throw;
            }
            return countriesEntity;

        }

        public static async void InsertAllCountries(IDAO<Country> _country, List<Country> countries)
        {
            try
            {
                
               await _country.CreateAsync(countries);
            }
            catch (Exception e)
            {
                throw;
            }

        }

    }
}
