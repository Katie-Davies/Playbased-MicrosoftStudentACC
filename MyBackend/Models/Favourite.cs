using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MyBackend.Models
{
  public class Favourite
  {
    [Key]
    public int Id { get; set; }
    public int ActivityId { get; set; }
    public Activity? Activity { get; set; }

    public int UserId { get; set; }
    public User? User { get; set; }
  }
}
