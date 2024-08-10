using adessoTaskApi.Models.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace adessoTaskApi.Data
{
    public class GroupDAO : IDAO<Group>
    {
        private readonly ApplicationDbContext _context;

        public GroupDAO(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Group> CreateAsync(Group entity)
        {

            _context.Groups.Add(entity);

            await _context.SaveChangesAsync();

            return entity;
        }
        public async Task<List<Group>> CreateAsync(List<Group> groups)
        {
            if (groups == null || !groups.Any())
            {
                throw new ArgumentException("Boş Olamaz", nameof(groups));
            }
            await _context.Groups.AddRangeAsync(groups);
            await _context.SaveChangesAsync();
            return groups;
        }

        public async Task<bool> DeleteAsync(int id)
        {

            var entity = await _context.Groups.FindAsync(id);
            if (entity == null)
            {
                return false; 
            }
            _context.Groups.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> DeleteAllAsync()
        {

            var entity = await _context.Groups.ToListAsync();
            if (entity == null)
            {
                return false;
            }
            _context.Groups.RemoveRange(entity);

            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Group>> GetAllAsync()
        {
            return await _context.Groups.ToListAsync();
        }

        public async Task<Group> GetByIdAsync(int id)
        {
            return await _context.Groups.FindAsync(id);
        }

        public async Task<bool> UpdateAsync(Group entity)
        {
            _context.Groups.Update(entity);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
