
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

        public async Task<List<Vak>> GetAllVakken()
        {
            var vakken = await _context.Vakken.ToListAsync();
            return vakken;
        }
    }
}

