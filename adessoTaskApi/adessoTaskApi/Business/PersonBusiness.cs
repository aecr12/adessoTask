using adessoTaskApi.Data;
using adessoTaskApi.Models.DTOModels;
using adessoTaskApi.Models.EntityModels;

namespace adessoTaskApi.Business
{
    public class PersonBusiness
    {
        
     
        public static async Task<GeneratorPerson> SelectPerson(IDAO<GeneratorPerson> _person, string name, string surname)
        {
            GeneratorPerson generatorPerson = new GeneratorPerson();
            try
            {
                PersonDAO _personDao = (PersonDAO)_person;
                generatorPerson = await _personDao.GetByNameSurname(name, surname);
            }
            catch (Exception e)
            {
                throw;
            }
            return generatorPerson;

        }
        public static async Task InsertPerson(IDAO<GeneratorPerson> _person, string name, string surname)
        {
            GeneratorPerson generatorPerson = new GeneratorPerson()
            {
                GeneratorName = name,
                GeneratorSurname   = surname    
            };
            try
            {
                PersonDAO _personDao = (PersonDAO)_person;
                generatorPerson = await _personDao.CreateAsync(generatorPerson);
            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}
