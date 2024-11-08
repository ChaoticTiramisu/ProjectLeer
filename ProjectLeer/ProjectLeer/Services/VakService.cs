using ProjectLeer.Data;
using ProjectLeer.Entity;
using Microsoft.EntityFrameworkCore;

namespace ProjectLeer.Services
{
public class VakService
{
    private readonly ApplicationDbContext _context;

    public VakService(ApplicationDbContext context)
    {
        _context = context;
    }

    // Create
    public async Task AddVakAsync(Vak vak)
    {
        _context.Vakken.Add(vak);
        await _context.SaveChangesAsync();
    }

    // Read
    public async Task<List<Vak>> GetAllVakkenAsync()
    {
        return await _context.Vakken.ToListAsync();
    }

    public async Task<Vak> GetVakByIdAsync(int id)
    {
        return await _context.Vakken.FindAsync(id);
    }

    // Update
    public async Task UpdateVakAsync(Vak vak)
    {
        _context.Vakken.Update(vak);
        await _context.SaveChangesAsync();
    }

    // Delete
    public async Task DeleteVakAsync(int id)
    {
        var vak = await _context.Vakken.FindAsync(id);
        if (vak != null)
        {
            _context.Vakken.Remove(vak);
            await _context.SaveChangesAsync();
        }
    }
}
}

