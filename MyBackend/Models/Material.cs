using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace MyBackend.Models
{
  public class Material
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<ActivityMaterial> ActivityMaterials { get; set; }
  }
}