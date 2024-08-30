using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace MyBackend.Models
{
  public class Activity
  {
    [Key]
    public int ActivityId { get; set; }
    public string ActivityName { get; set; }
    public string Description { get; set; }

    public int AgeGroupID { get; set; }
    //provides a diret reference to 
    public AgeGroup? AgeGroup { get; set; }

    public int CategoryID { get; set; }
    //provides a diret reference to 
    public Category? Category { get; set; }

    public string ImageUrl { get; set; } // Add this property

    // These represent the relationship i.e many to many
    public ICollection<Favourite> Favourites { get; set; }
    public ICollection<ActivityMaterial> ActivityMaterials { get; set; }


    public Activity()
    {
      Favourites = new List<Favourite>();
      ActivityMaterials = new List<ActivityMaterial>();
      ActivityName = "";
      Description = "";
      ImageUrl = "";
    }
  }
}