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
      modelBuilder.Entity<Activity>().HasOne(a => a.Category).WithMany(c => c.Activities).HasForeignKey(a => a.CategoryId);
      modelBuilder.Entity<Activity>().HasOne(a => a.AgeGroup).WithMany(ag => ag.Activities).HasForeignKey(a => a.AgeGroupId);

      //configure many-to-many relationships
      modelBuilder.Entity<ActivityMaterial>().HasKey(am => new { am.ActivityId, am.MaterialId });
      modelBuilder.Entity<ActivityMaterial>().HasOne(am => am.Activity).WithMany(a => a.ActivityMaterials).HasForeignKey(am => am.ActivityId);
      modelBuilder.Entity<ActivityMaterial>().HasOne(am => am.Material).WithMany(m => m.ActivityMaterials).HasForeignKey(am => am.MaterialId);

      // Configure many-to-many relationship between User and Activity through Favourite
      modelBuilder.Entity<Favourite>().HasOne(f => f.Activity).WithMany(a => a.Favourites).HasForeignKey(f => f.ActivityId);
      modelBuilder.Entity<Favourite>().HasOne(f => f.User).WithMany(u => u.Favourites).HasForeignKey(f => f.UserId);
    }



  }
}