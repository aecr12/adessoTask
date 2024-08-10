using adessoTaskApi.Models.DTOModels;
using adessoTaskApi.Models.EntityModels;

namespace adessoTaskApi.Mappers
{
    public class CountryMapper
    {

        public static List<CountryDTO> entityToDtoList(List<Country> countries)
        {
            return countries.Select(c => EntityToDTO(c)).ToList();
        }
        public static List<Country> DtoToEntityList(List<CountryDTO> countries)
        {
            return countries.Select(c => DTOToEntity(c)).ToList();
        }
        public static CountryDTO EntityToDTO(Country country) {

            return new CountryDTO
            {
                CountryId = (byte) country.CountryId,
                CountryName = country.CountryName
            };

        }
        public static Country DTOToEntity(CountryDTO country)
        {

            return new Country
            {
                CountryId = (byte)country.CountryId,
                CountryName = country.CountryName
            };

        }
    }
}
