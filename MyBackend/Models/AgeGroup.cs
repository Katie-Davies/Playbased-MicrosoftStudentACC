using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyBackend.Models
{
  public class AgeGroup
  {
    [Key]
    public int id { get; set; }
    public required string Range { get; set; }

    public required ICollection<Activity> Activities { get; set; }
  }
}