using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace MyBackend.Models
{
  public class ActivityMaterial
  {
    [Key]

    public int MaterialId { get; set; }

    public Material? Material { get; set; }

    public int ActivityId { get; set; }

    public Activity? Activity { get; set; }

  }
}