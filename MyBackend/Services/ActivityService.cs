// ActivityService.cs
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using MyBackend.Data;
using MyBackend.Models;
using System.Formats.Asn1;

public class ActivityService : IActivityService
{
  private readonly ApplicationDbContext _context;

  public ActivityService(ApplicationDbContext context)
  {
    _context = context;
  }

  public async Task<List<Activity>> GetAllActivitiesAsync()
  {
    return await _context.Activities.ToListAsync();
  }
  public async Task<List<Activity>> GetActivitiesByAgeGroupAsync(int ageGroupId)
  {
    return await _context.Activities
        .Where(a => a.AgeGroupID == ageGroupId)
        .ToListAsync();
  }
  public async Task<List<Activity>> GetActivitiesByIdAsync(int id)
  {
    return await _context.Activities.Where(a => a.ActivityId == id).Include(a => a.ActivityMaterials).ThenInclude(am => am.Material).ToListAsync();
  }
  public async Task<List<Activity>> GetActivitiesByCategoryAsync(int categoryId)
  {
    return await _context.Activities.Where(a => a.CategoryID == categoryId).ToListAsync();
  }

  public async Task<int?> GetMaterialIdByNameAsync(string materialName)
  {
    var material = await _context.Materials.FirstOrDefaultAsync(m => m.MaterialName == materialName);
    return material?.MaterialID;
  }


}
