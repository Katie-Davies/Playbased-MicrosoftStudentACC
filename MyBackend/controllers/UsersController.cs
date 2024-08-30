using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyBackend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
  private readonly IUserService _userService;

  public UsersController(IUserService userService)
  {
    _userService = userService;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<User>>> GetUsers()
  {
    var users = await _userService.GetAllUsersAsync();
    if (users == null || users.Count == 0)
    {
      return NotFound();
    }
    return Ok(users);
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<User>> GetUserByIdAsync(int id)
  {
    var users = await _userService.GetUserByIdAsync(id);
    if (users == null)
    {
      return NotFound();
    }
    return Ok(users);
  }
  [HttpPost]
  public async Task<ActionResult<User>> CreateUserAsync(User user)
  {
    var newUser = await _userService.CreateUserAsync(user);
    return Ok(newUser);
  }
  [HttpPut]
  public async Task<ActionResult<User>> UpdateUserAsync(User user)
  {
    var updatedUser = await _userService.UpdateUserAsync(user);
    return Ok(updatedUser);
  }
  [HttpDelete("{id}")]
  public async Task<ActionResult> DeleteUserAsync(int id)
  {

    var result = await _userService.DeleteUserAsync(id);

    if (result == "User not found")
    {
      return NotFound(new { message = result });
    }
    else if (result == "User deleted")
    {
      return NoContent(); // 204 No Content
    }
    else
    {
      return BadRequest(new { message = result }); // Handle other potential error messages
    }
  }
}