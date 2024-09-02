using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using MyBackend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ActivitiesController : ControllerBase
{
  private readonly IActivityService _activityService;

  public ActivitiesController(IActivityService activityService)
  {
    _activityService = activityService;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<Activity>>> GetActivities()
  {
    var activities = await _activityService.GetAllActivitiesAsync();
    return Ok(activities);
  }

  [HttpGet("ageGroup/{ageGroupId}")]
  public async Task<ActionResult<IEnumerable<Activity>>> GetActivitiesByAgeGroup(int ageGroupId)
  {
    var activities = await _activityService.GetActivitiesByAgeGroupAsync(ageGroupId);
    if (activities.Count == 0 || activities == null)
    {
      return NotFound();
    }
    return Ok(activities);
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<IEnumerable<Activity>>> GetActivitiesByIdAsync(int id)
  {
    var activities = await _activityService.GetActivitiesByIdAsync(id);
    if (activities.Count == 0 || activities == null)
    {
      return NotFound();
    }
    return Ok(activities);
  }
  [HttpGet("category/{categoryId}")]
  public async Task<ActionResult<IEnumerable<Activity>>> GetActivitiesByCategory(int categoryId)
  {
    var activities = await _activityService.GetActivitiesByCategoryAsync(categoryId);
    if (activities.Count == 0 || activities == null)
    {
      return NotFound();
    }
    return Ok(activities);
  }
  [HttpGet("materials/{materialName}")]
  public async Task<ActionResult<IEnumerable<Activity>>> GetMaterialIdByNameAsync(string materialName)
  {
    var materialId = await _activityService.GetMaterialIdByNameAsync(materialName);
    if (materialId == null)
    {
      return NotFound();
    }
    var activities = await _activityService.GetActivitiesByMaterialAsync(materialId.Value);
    if (activities.Count == 0 || activities == null)
    {
      return NotFound();
    }
    return Ok(activities);
  }
}
