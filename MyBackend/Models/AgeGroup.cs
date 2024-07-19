using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyBackend.Models
{
  public class AgeGroup
  {
    [Key]
    public int id { get; set; }
    public string Range { get; set; }

    public ICollection<Activity> Activities { get; set; }

    public AgeGroup()
    {
      Activities = new List<Activity>();
      Range = "";
    }
  }
}