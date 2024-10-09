using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBackend.Data; // Namespace for your DbContext

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
  private readonly ApplicationDbContext _context;
  private readonly ILogger<TestController> _logger;

  public TestController(ApplicationDbContext context, ILogger<TestController> logger)
  {
    _context = context;
    _logger = logger;
  }

  [HttpGet("test-connection")]
  public async Task<IActionResult> TestConnection()
  {
    try
    {
      var connectionString = _context.Database.GetDbConnection().ConnectionString;
      _logger.LogInformation($"Connection String: {connectionString}");
      // Perform a simple query to check if the connection is working
      var isConnected = await _context.Database.CanConnectAsync();
      return Ok(new { Success = isConnected, Message = isConnected ? "Connected to the database." : "Failed to connect to the database." });
    }
    catch (Exception ex)
    {
      // Handle the exception and return an error response
      return StatusCode(500, new { Success = false, Message = ex.Message });
    }
  }
}
