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
        new Material { MaterialID = 10, MaterialName = "Paper" },
        new Material { MaterialID = 11, MaterialName = "Paint" },
        new Material { MaterialID = 12, MaterialName = "Cornflour" },
        new Material { MaterialID = 13, MaterialName = "Balloons" },
        new Material { MaterialID = 14, MaterialName = "Bubbles" },
        new Material { MaterialID = 15, MaterialName = "Rice" },
        new Material { MaterialID = 16, MaterialName = "Pasta" },
        new Material { MaterialID = 17, MaterialName = "Glitter" },
        new Material { MaterialID = 18, MaterialName = "Pom Poms" },
        new Material { MaterialID = 19, MaterialName = "Pipe Cleaners" },
        new Material { MaterialID = 20, MaterialName = "Cotton Balls" },
        new Material { MaterialID = 21, MaterialName = "Feathers" },
        new Material { MaterialID = 22, MaterialName = "Buttons" },
        new Material { MaterialID = 23, MaterialName = "Beads" },
        new Material { MaterialID = 24, MaterialName = "Sequins" },
        new Material { MaterialID = 25, MaterialName = "Glue" },
        new Material { MaterialID = 26, MaterialName = "Tape" },
        new Material { MaterialID = 27, MaterialName = "Scissors" },
        new Material { MaterialID = 28, MaterialName = "Hole Punch" },
        new Material { MaterialID = 29, MaterialName = "Ruler" },
        new Material { MaterialID = 30, MaterialName = "Stapler" },
        new Material { MaterialID = 31, MaterialName = "Paper Clips" },
        new Material { MaterialID = 32, MaterialName = "Rubber Bands" },
        new Material { MaterialID = 33, MaterialName = "String" },
        new Material { MaterialID = 34, MaterialName = "Yarn" },
        new Material { MaterialID = 35, MaterialName = "Fabric" },
        new Material { MaterialID = 36, MaterialName = "Felt" },
        new Material { MaterialID = 37, MaterialName = "Foam" },
        new Material { MaterialID = 38, MaterialName = "Wood" },
        new Material { MaterialID = 39, MaterialName = "Plastic" },
        new Material { MaterialID = 40, MaterialName = "Metal" },
        new Material { MaterialID = 41, MaterialName = "Glass" },
        new Material { MaterialID = 42, MaterialName = "Ceramic" },
        new Material { MaterialID = 43, MaterialName = "Paper Mache" },
        new Material { MaterialID = 44, MaterialName = "Cardboard" },
        new Material { MaterialID = 45, MaterialName = "Recycled Materials" },
        new Material { MaterialID = 46, MaterialName = "Natural Materials" }
        // Add other materials as needed
      );

      modelBuilder.Entity<Activity>().HasData(
new Activity { ActivityId = 1, ActivityName = "Building Blocks", Description = "Build a tower with blocks", CategoryID = 2, AgeGroupID = 2 },
      );

    }



  }
}