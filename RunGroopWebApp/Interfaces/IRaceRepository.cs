using RunGroopWebApp.Models;

namespace RunGroopWebApp.Interfaces
{
    public interface IRaceRepository
    {

        Task<IEnumerable<Race>> GetAllAsync();

        Task<IEnumerable<Race>> GetAllByCityAsync(string city);

        Task<Race> GetByIdAsync(int id);

        bool Add(Race race);

        bool Delete(Race race);

        bool Update(Race race);

        bool Save();

    }
}
