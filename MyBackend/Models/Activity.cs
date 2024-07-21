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
    public string Description { get; set; }

    public int AgeGroupId { get; set; }
    //provides a diret reference to 
    public AgeGroup? AgeGroup { get; set; }

    public int CategoryId { get; set; }
    //provides a diret reference to 
    public Category? Category { get; set; }

    // These represent the relationship i.e many to many
    public ICollection<Favourite> Favourites { get; set; }
    public ICollection<ActivityMaterial> ActivityMaterials { get; set; }


    public Activity()
    {
      Favourites = new List<Favourite>();
      ActivityMaterials = new List<ActivityMaterial>();
      Title = "";
      Description = "";
    }
  }
}