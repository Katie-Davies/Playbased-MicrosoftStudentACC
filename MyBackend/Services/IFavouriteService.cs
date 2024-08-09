using System.Collections.Generic;
using System.Threading.Tasks;
using MyBackend.Models;

public interface IFavouriteService
{
  Task<List<Favourite>> GetAllFavouritesByUserIdAsync(int id);
  Task<Favourite> AddFavouriteAsync(Favourite favourite);
  Task<string> DeleteFavouriteAsync(int id);

}