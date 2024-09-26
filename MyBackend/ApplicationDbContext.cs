using Microsoft.EntityFrameworkCore;
using MyBackend.Models;

namespace MyBackend.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Material> Materials { get; set; }
    public DbSet<Activity> Activities { get; set; }
    public DbSet<Favourite> Favourites { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<AgeGroup> AgeGroups { get; set; }
    public DbSet<ActivityMaterial> ActivityMaterials { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      //configure one-to-many relationships
      modelBuilder.Entity<Activity>().HasOne(a => a.Category).WithMany(c => c.Activities).HasForeignKey(a => a.CategoryID);
      modelBuilder.Entity<Activity>().HasOne(a => a.AgeGroup).WithMany(ag => ag.Activities).HasForeignKey(a => a.AgeGroupID);

      //configure many-to-many relationships
      modelBuilder.Entity<ActivityMaterial>().HasKey(am => new { am.ActivityId, am.MaterialId });
      modelBuilder.Entity<ActivityMaterial>().HasOne(am => am.Activity).WithMany(a => a.ActivityMaterials).HasForeignKey(am => am.ActivityId);
      modelBuilder.Entity<ActivityMaterial>().HasOne(am => am.Material).WithMany(m => m.ActivityMaterials).HasForeignKey(am => am.MaterialId);

      // Configure many-to-many relationship between User and Activity through Favourite
      modelBuilder.Entity<Favourite>().HasOne(f => f.Activity).WithMany(a => a.Favourites).HasForeignKey(f => f.ActivityId);
      modelBuilder.Entity<Favourite>().HasOne(f => f.User).WithMany(u => u.Favourites).HasForeignKey(f => f.UserId);

      //seed data 
      // seed ageGroups 
      modelBuilder.Entity<AgeGroup>().HasData(
        new AgeGroup { id = 1, Range = "0-2 years" },
        new AgeGroup { id = 2, Range = "3-5 years" },
        new AgeGroup { id = 3, Range = "6-8 years" },
        new AgeGroup { id = 4, Range = "9-12 years" }
      );
      modelBuilder.Entity<Category>().HasData(
new Category { CategoryId = 1, Name = "Imaginative Play" },
new Category { CategoryId = 2, Name = "Construction" },
new Category { CategoryId = 3, Name = "Art" },
new Category { CategoryId = 4, Name = "Fantasy" },
new Category { CategoryId = 5, Name = "Sensory" },
new Category { CategoryId = 6, Name = "Games with Rules" },
new Category { CategoryId = 7, Name = "Physical" },
new Category { CategoryId = 8, Name = "Exploration" }
      );


      // Seed Materials
      modelBuilder.Entity<Material>().HasData(
        new Material { MaterialID = 1, MaterialName = "Blocks" },
        new Material { MaterialID = 2, MaterialName = "Puzzles" },
        new Material { MaterialID = 3, MaterialName = "Books" },
        new Material { MaterialID = 4, MaterialName = "Art Supplies" },
        new Material { MaterialID = 5, MaterialName = "Dough" },
        new Material { MaterialID = 6, MaterialName = "Lego" },
        new Material { MaterialID = 7, MaterialName = "Cardboard" },
        new Material { MaterialID = 8, MaterialName = "Markers" },
        new Material { MaterialID = 9, MaterialName = "Stickers" },
        new Material { MaterialID = 10, MaterialName = "Paper" }
        // Add other materials as needed
      );

    }



  }
}