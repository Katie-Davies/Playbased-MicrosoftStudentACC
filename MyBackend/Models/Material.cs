using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MyBackend.Models
{
  public class Material
  {
    [Key]
    public int MaterialID { get; set; }
    public string MaterialName { get; set; }
    public ICollection<ActivityMaterial> ActivityMaterials { get; set; }

    public Material()
    {
      ActivityMaterials = new List<ActivityMaterial>();
      MaterialName = "";
    }
  }
}