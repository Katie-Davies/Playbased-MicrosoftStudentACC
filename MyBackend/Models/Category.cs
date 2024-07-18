using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyBackend.Models
{
  public class Category
  {

    [Key]
    public int CategoryId { get; set; }

    public string Name { get; set; }

    public ICollection<Activity> Activities { get; set; }
  }
}