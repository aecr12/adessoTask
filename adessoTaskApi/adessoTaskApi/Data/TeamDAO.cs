using adessoTaskApi.Models.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace adessoTaskApi.Data
{
    public class TeamDAO:IDAO<Team>
    {
        private readonly ApplicationDbContext _context;

        public TeamDAO(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Team> CreateAsync(Team entity)
        {

            _context.Teams.Add(entity);

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<List<Team>> CreateAsync(List<Team> teams)
        {
            if (teams == null || !teams.Any())
            {
                throw new ArgumentException("Boş Olamaz", nameof(teams));
            }
            await _context.Teams.AddRangeAsync(teams);
            await _context.SaveChangesAsync();
            return teams;
        }


        public async Task<bool> DeleteAsync(int id)
        {

            var entity = await _context.Teams.FindAsync(id);
            if (entity == null)
            {
                return false;
            }
            _context.Teams.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> DeleteAllAsync()
        {

            var entity = await _context.Teams.ToListAsync();
            if (entity == null)
            {
                return false;
            }
            _context.Teams.RemoveRange(entity);

            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<IEnumerable<Team>> GetAllAsync()
        {
            return await _context.Teams.ToListAsync();
        }

        public async Task<Team> GetByIdAsync(int id)
        {
            return await _context.Teams.FindAsync(id);
        }

        public async Task<bool> UpdateAsync(Team entity)
        {
            _context.Teams.Update(entity);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
