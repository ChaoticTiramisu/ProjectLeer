using ProjectLeer.Entity;
namespace ProjectLeer.Services
{
    public interface IVakService
    {
        Task<List<Vak>> GetAllVakken();
    }
}
