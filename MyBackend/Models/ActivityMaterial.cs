using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MyBackend.Models
{
  public class ActivityMaterial
  {
    [Key]
    public int ActivityId { get; set; }
    public Activity? Activity { get; set; }
    public int MaterialId { get; set; }
    public Material? Material { get; set; }
  }
}