// IActivityService.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using MyBackend.Models;

public interface IActivityService
{
  Task<List<Activity>> GetAllActivitiesAsync();
  Task<List<Activity>> GetActivitiesByAgeGroupAsync(int ageGroupId);

  Task<List<Activity>> GetActivitiesByIdAsync(int id);
  Task<List<Activity>> GetActivitiesByCategoryAsync(int categoryId);

}