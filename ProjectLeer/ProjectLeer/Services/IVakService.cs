using ProjectLeer.Entity;
namespace ProjectLeer.Services
{
    public interface IVakService
    {
        Task<List<Vak>> GetAllVakken();
        Task<Vak> GetVakById(int id);
        Task<Vak> AddVak(Vak vak);
        Task<Vak> EditVak(int id, Vak vak);
        Task<bool> DeleteVak(int id);
    }
}
