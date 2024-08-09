//FavouriteService.cs
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyBackend.Data;
using MyBackend.Models;
using Microsoft.Extensions.ObjectPool;

public class FavouriteService : IFavouriteService
{
  private readonly ApplicationDbContext _context;

  public FavouriteService(ApplicationDbContext context)
  {
    _context = context;
  }
  public async Task<List<Favourite>> GetAllFavouritesByUserIdAsync(int id)
  {
    return await _context.Favourites.Where(f => f.UserId == id).ToListAsync(); ;
  }

  public async Task<Favourite> AddFavouriteAsync(Favourite favourite)
  {
    await _context.Favourites.AddAsync(favourite);
    await _context.SaveChangesAsync();
    return favourite;
  }
  public async Task<string> DeleteFavouriteAsync(int id)
  {
    var favourite = await _context.Favourites.FindAsync(id);
    if (favourite == null)
    {
      return "Favourite not found";
    }
    _context.Favourites.Remove(favourite);
    await _context.SaveChangesAsync();
    return "Favourite deleted";
  }


}