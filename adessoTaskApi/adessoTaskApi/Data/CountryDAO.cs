using adessoTaskApi.Models.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace adessoTaskApi.Data
{
    public class CountryDAO:IDAO<Country>
    {
        private readonly ApplicationDbContext _context;

        public CountryDAO(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Country> CreateAsync(Country entity)
        {

            _context.Countries.Add(entity);

            await _context.SaveChangesAsync();

            return entity;
        }
        public async Task<List<Country>> CreateAsync(List<Country> Countries)
        {
            if (Countries == null || !Countries.Any())
            {
                throw new ArgumentException("Boş Olamaz", nameof(Countries));
            }
            await _context.Countries.AddRangeAsync(Countries);
            await _context.SaveChangesAsync();
            return Countries;
        }

        public async Task<bool> DeleteAsync(int id)
        {

            var entity = await _context.Countries.FindAsync(id);
            if (entity == null)
            {
                return false;
            }
            _context.Countries.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> DeleteAllAsync()
        {

            var entity = await _context.Countries.ToListAsync();
            if (entity == null)
            {
                return false;
            }
            _context.Countries.RemoveRange(entity);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Country>> GetAllAsync()
        {
            return await _context.Countries.ToListAsync();
        }

        public async Task<Country> GetByIdAsync(int id)
        {
            return await _context.Countries.FindAsync(id);
        }

        public async Task<bool> UpdateAsync(Country entity)
        {
            _context.Countries.Update(entity);

            return await _context.SaveChangesAsync() > 0;
        }

   
    }
}
