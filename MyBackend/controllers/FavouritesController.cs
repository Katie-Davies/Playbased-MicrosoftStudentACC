using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyBackend.Dtos;
using MyBackend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]

public class FavouritesController : ControllerBase
{
  private readonly IFavouriteService _favouriteService;

  public FavouritesController(IFavouriteService favouriteService)
  {
    _favouriteService = favouriteService;
  }

  [HttpGet("{id}", Name = "GetFavouritesByUserId")]
  public async Task<ActionResult<IEnumerable<Favourite>>> GetFavouritesByUserIdAsync(int id)
  {
    var favourites = await _favouriteService.GetAllFavouritesByUserIdAsync(id);
    if (favourites.Count == 0 || favourites == null)
    {
      return NotFound();
    }
    return Ok(favourites);
  }

  [HttpPost]
  public async Task<ActionResult<Favourite>> AddFavouriteAsync(FavouriteDto favouriteDto)
  {
    var favourite = new Favourite
    {
      ActivityId = favouriteDto.ActivityId,
      UserId = favouriteDto.UserId
    };

    var newFavourite = await _favouriteService.AddFavouriteAsync(favourite);
    return CreatedAtRoute(
            routeName: "GetFavouritesByUserId", // Ensure this route exists
            routeValues: new { id = favouriteDto.UserId }, // Use appropriate parameter
            value: newFavourite);
  }
  [HttpDelete("{id}")]
  public async Task<ActionResult> DeleteFavouriteAsync(int id)
  {
    var result = await _favouriteService.DeleteFavouriteAsync(id);
    if (result == "Favourite not found")
    {
      return NotFound(new { message = result });
    }
    else if (result == "Favourite deleted")
    {
      return NoContent();
    }
    else
    {
      return BadRequest(new { message = result });
    }
  }
}