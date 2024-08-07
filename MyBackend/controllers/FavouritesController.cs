using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
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

  [HttpGet("{id}")]
  public async Task<ActionResult<IEnumerable<Favourite>>> GetFavouritesByUserIdAsync(int id)
  {
    var favourites = await _favouriteService.GetAllFavouritesByUserIdAsync(id);
    if (favourites.Count == 0 || favourites == null)
    {
      return NotFound();
    }
    return Ok(favourites);
  }
}