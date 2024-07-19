using System.Collections.Generic;
using System.Threading.Tasks;
using MyBackend.Models;


public interface IUserService
{
  Task<List<User>> GetAllUsersAsync();
  Task<List<User>> GetUserByIdAsync(int id);

  Task<User> CreateUserAsync(User user);
  Task<User> UpdateUserAsync(User user);
  Task<string> DeleteUserAsync(int id);
}