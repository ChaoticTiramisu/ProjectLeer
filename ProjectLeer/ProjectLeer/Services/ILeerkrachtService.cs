using ProjectLeer.Entity;
namespace ProjectLeer.Services
{
    public interface ILeerkrachtService
    {
        Task<List<Leerkracht>> GetAllLeerkrachten();
        Task<Leerkracht> GetLeerkrachtById(int id);
        Task<Leerkracht> AddLeerkracht(Leerkracht leerkracht);
        Task<Leerkracht> EditLeerkracht(int id, Leerkracht leerkracht);
        Task<bool> DeleteLeerkracht(int id);
    }
}
