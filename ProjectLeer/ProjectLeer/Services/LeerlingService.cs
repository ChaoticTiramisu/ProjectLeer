
using ProjectLeer.Data;
using Microsoft.EntityFrameworkCore;
using ProjectLeer.Entity;

namespace ProjectLeer.Services
{
    public class LeerlingService : ILeerlingService
    {
        private readonly DataContext _context;

        public LeerlingService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Vak>> GetLeerlingVakken(int id)
        {
            var leerling = await _context.Leerlingen
                .Include(leerling => leerling.Vakken) // Eagerly load the related Vakken
                .FirstOrDefaultAsync(leerling => leerling.Id == id); // Find the Leerling by Id

            if (leerling == null)
            {
                return new List<Vak>(); // Return an empty list if the Leerling is not found
            }

            return leerling.Vakken; // Return the list of Vakken for the specific Leerling
        }

    }
}

