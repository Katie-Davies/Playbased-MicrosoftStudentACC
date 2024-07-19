using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyBackend.Data;
using MyBackend.Models;
using System.Runtime.CompilerServices;

public class UserService : IUserService
{
  private readonly ApplicationDbContext _context;

  public UserService(ApplicationDbContext context)
  {
    _context = context;
  }
  public async Task<List<User>> GetAllUsersAsync()
  {
    return await _context.Users.ToListAsync();
  }
  public async Task<List<User>> GetUserByIdAsync(int id)
  {
    return await _context.Users.Where(u => u.Id == id).ToListAsync();
  }

  public async Task<User> CreateUserAsync(User user)
  {
    await _context.Users.AddAsync(user);
    await _context.SaveChangesAsync();
    return user;
  }

  public async Task<User> UpdateUserAsync(User user)
  {
    _context.Users.Update(user);
    await _context.SaveChangesAsync();
    return user;
  }
  public async Task<String> DeleteUserAsync(int id)
  {
    var user = await _context.Users.FindAsync(id);
    if (user == null)
    {
      return "User not found";
    }
    _context.Users.Remove(user);
    await _context.SaveChangesAsync();
    return "User deleted";
  }

}