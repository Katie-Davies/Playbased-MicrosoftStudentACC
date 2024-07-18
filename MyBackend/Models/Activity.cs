using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace MyBackend.Models
{
  public class Activity
  {
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set}

    public int AgeGroupId { get; set; }
    public AgeGroup AgeGroup { get; set; }

    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public ICollection<Favourite> Favourites { get; set; }
    public ICollection<ActivityMaterial> ActivityMaterials { get; set; }

  }
}