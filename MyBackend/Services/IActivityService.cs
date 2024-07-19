// IActivityService.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using MyBackend.Models;

public interface IActivityService
{
  Task<List<Activity>> GetAllActivitiesAsync();
}