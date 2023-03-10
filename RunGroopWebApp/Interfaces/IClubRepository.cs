using RunGroopWebApp.Models;

namespace RunGroopWebApp.Interfaces
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAllAsync();

        Task<Club> GetByIdAsync(int id);

        Task<IEnumerable<Club>> GetAllByCityAsync(string city);

        bool Add(Club club);

        bool Update(Club club);

        bool Delete(Club club);

        bool Save();

    }
}
