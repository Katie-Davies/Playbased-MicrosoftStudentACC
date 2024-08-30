using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyBackend.Models
{
  public class User
  {
    [Key]
    public int UserID { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }

    public ICollection<Favourite> Favourites { get; set; }

    public User()
    {
      Favourites = new List<Favourite>();
      Username = "";
      Email = "";
    }
  }
}