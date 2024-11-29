using ProjectLeer.Entity;
namespace ProjectLeer.Services
{
    public interface ILeerlingService
    {
        Task<List<Vak>> GetLeerlingVakken(int id);
        
    }
}
