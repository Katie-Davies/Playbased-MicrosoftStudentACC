using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MyBackend.Models
{
  public class ActivityMaterial
  {
    [Key]
    public int ActivityId { get; set; }
    public required Activity Activity { get; set; }
    public int MaterialId { get; set; }
    public required Material Material { get; set; }
  }
}