
using ProjectLeer.Data;
using Microsoft.EntityFrameworkCore;
using ProjectLeer.Entity;
namespace ProjectLeer.Services
{
    public class VakService : IVakService
    {
        private readonly DataContext _context;

        public VakService(DataContext context)
        {
            _context = context;
        }

        public async Task<Vak> AddVak(Vak vak)
        {
            _context.Vakken.Add(vak);
            await _context.SaveChangesAsync();
            return vak;
        }

        public async Task<bool> DeleteVak(int id)
        {
            var DbVak = await _context.Vakken.FindAsync(id);
            if(DbVak != null)
            {
                _context.Remove(DbVak);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<Vak> EditVak(int id, Vak vak)
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

        public async Task<List<Vak>> GetAllVakken()
        {
            var vakken = await _context.Vakken.ToListAsync();
            return vakken;
        }

        public async Task<Vak> GetVakById(int id)
        {
            return await _context.Vakken.FindAsync(id);
        }
    }
}

