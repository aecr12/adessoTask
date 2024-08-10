using adessoTaskApi.Models.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace adessoTaskApi.Data
{
    public class PersonDAO : IDAO<GeneratorPerson>
    
    {
        private readonly ApplicationDbContext _context;

        public PersonDAO(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<GeneratorPerson> CreateAsync(GeneratorPerson entity)
        {

            _context.GeneratorPersons.Add(entity);

            await _context.SaveChangesAsync();

            return entity;
        }
        public async Task<List<GeneratorPerson>> CreateAsync(List<GeneratorPerson> Persons)
        {
            if (Persons == null || !Persons.Any())
            {
                throw new ArgumentException("Boş Olamaz", nameof(Persons));
            }
            await _context.GeneratorPersons.AddRangeAsync(Persons);
            await _context.SaveChangesAsync();
            return Persons;
        }

        public async Task<bool> DeleteAsync(int id)
        {

            var entity = await _context.GeneratorPersons.FindAsync(id);
            if (entity == null)
            {
                return false;
            }
            _context.GeneratorPersons.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> DeleteAllAsync()
        {

            var entity = await _context.GeneratorPersons.ToListAsync();
            if (entity == null)
            {
                return false;
            }
            _context.GeneratorPersons.RemoveRange(entity);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<GeneratorPerson>> GetAllAsync()
        {
            return await _context.GeneratorPersons.ToListAsync();
        }

        public async Task<GeneratorPerson> GetByIdAsync(int id)
        {
            return await _context.GeneratorPersons.FindAsync(id);
        }
        public async Task<GeneratorPerson> GetByNameSurname(string name, string surname)
        {
            return await _context.GeneratorPersons.FirstOrDefaultAsync(e => e.GeneratorName == name && e.GeneratorSurname == surname);
        }
        public async Task<bool> UpdateAsync(GeneratorPerson entity)
        {
            _context.GeneratorPersons.Update(entity);

            return await _context.SaveChangesAsync() > 0;
        }

   
    }
}
