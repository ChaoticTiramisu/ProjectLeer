
using ProjectLeer.Data;
using Microsoft.EntityFrameworkCore;
using ProjectLeer.Entity;
namespace ProjectLeer.Services
{
    public class LeerkrachtService : ILeerkrachtService
    {
        private readonly DataContext _context;

        public LeerkrachtService(DataContext context)
        {
            _context = context;
        }

        public async Task<Leerkracht> AddLeerkracht(Leerkracht leerkracht)
        {
            _context.Leerkrachten.Add(leerkracht);
            await _context.SaveChangesAsync();
            return leerkracht;
        }


        public async Task<bool> DeleteLeerkracht(int id)
        {
            var DbVak = await _context.Leerkrachten.FindAsync(id);
            if(DbVak != null)
            {
                _context.Remove(DbVak);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<Vak> EditLeerkracht(int id, Vak vak)
        {
            var DbVak = await _context.Vakken.FindAsync(id);
            if (DbVak != null)
            {
                DbVak.Naam = vak.Naam;
                await _context.SaveChangesAsync();
                return DbVak;
            }
            throw new Exception("Vak niet gevonden");

            
        }

        public Task<Leerkracht> EditLeerkracht(int id, Leerkracht leerkracht)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Vak>> GetAllLeerkrachten()
        {
            var vakken = await _context.Vakken.ToListAsync();
            return vakken;
        }

        public async Task<Vak> GetLeerkrachtById(int id)
        {
            return await _context.Vakken.FindAsync(id);
        }

        Task<List<Leerkracht>> ILeerkrachtService.GetAllLeerkrachten()
        {
            throw new NotImplementedException();
        }

        Task<Leerkracht> ILeerkrachtService.GetLeerkrachtById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

