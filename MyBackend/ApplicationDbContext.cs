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
        new Material { MaterialID = 46, MaterialName = "Natural Materials" },
        new Material { MaterialID = 47, MaterialName = "Water" }
        new Material { MaterialID = 48, MaterialName = "Baking soda" },
        new Material { MaterialID = 49, MaterialName = "Vinegar" },
        new Material { MaterialID = 50, MaterialName = "Food coloring" },
        new Material { MaterialID = 51, MaterialName = "Computer" },
        // Add other materials as needed
      );

      modelBuilder.Entity<Activity>().HasData(
new Activity { ActivityId = 1, ActivityName = "Cloud Dough", Description = "Making and playing with cloud dough", AgeGroupID = 1, CategoryID = 5 },
new Activity { ActivityId = 2, ActivityName = "Stacking Blocks", Description = "Stacking different types of blocks.", AgeGroupID = 1, CategoryID = 2 },
new Activity { ActivityId = 3, ActivityName = "Animal Sounds", Description = "Identifying animal sounds from a book.", AgeGroupID = 1, CategoryID = 4 },
new Activity { ActivityId = 4, ActivityName = "Finger Painting", Description = "Creating art using finger paints.", AgeGroupID = 1, CategoryID = 3 },
new Activity { ActivityId = 5, ActivityName = "Bubble Wrap Play", Description = "Popping bubble wrap for sensory play.", AgeGroupID = 1, CategoryID = 5 },
new Activity { ActivityId = 6, ActivityName = "Water Play", Description = "Splashing and playing with water.", AgeGroupID = 1, CategoryID = 7 },
new Activity { ActivityId = 7, ActivityName = "Sensory Bottles", Description = "Exploring sensory bottles filled with different materials.", AgeGroupID = 1, CategoryID = 5 },
new Activity { ActivityId = 8, ActivityName = "Pretend Cooking", Description = "Pretend cooking with toy food.", AgeGroupID = 1, CategoryID = 1 },
new Activity { ActivityId = 9, ActivityName = "Making Dragons", Description = "Crafting dragons out of toilet roll cardboard.", AgeGroupID = 2, CategoryID = 4 },
new Activity { ActivityId = 10, ActivityName = "Building with Lego", Description = "Creating structures with Lego.", AgeGroupID = 2, CategoryID = 2 },
new Activity { ActivityId = 11, ActivityName = "Sticker Collage", Description = "Making a collage with various stickers.", AgeGroupID = 2, CategoryID = 3 },
new Activity { ActivityId = 12, ActivityName = "Dress-Up Play", Description = "Engaging in dress-up and role play.", AgeGroupID = 2, CategoryID = 1 },
new Activity { ActivityId = 13, ActivityName = "Nature Walk", Description = "Collecting natural items during a nature walk.", AgeGroupID = 2, CategoryID = 8 },
new Activity { ActivityId = 14, ActivityName = "Lego Castle", Description = "Building a castle with Lego.", AgeGroupID = 2, CategoryID = 2 },
new Activity { ActivityId = 15, ActivityName = "Making Pizza", Description = "Pretend making pizza with play dough.", AgeGroupID = 2, CategoryID = 1 },
new Activity { ActivityId = 16, ActivityName = "Obstacle Course", Description = "Navigating a simple obstacle course.", AgeGroupID = 2, CategoryID = 7 },
new Activity { ActivityId = 17, ActivityName = "Origami Animals", Description = "Folding paper to create animal shapes.", AgeGroupID = 3, CategoryID = 3 },
new Activity { ActivityId = 18, ActivityName = "Volcano Experiment", Description = "Creating a baking soda and vinegar volcano.", AgeGroupID = 3, CategoryID = 8 },
new Activity { ActivityId = 19, ActivityName = "Relay Races", Description = "Participating in relay races with rules.", AgeGroupID = 3, CategoryID = 6 },
new Activity { ActivityId = 20, ActivityName = "Fantasy Map Making", Description = "Creating maps for fantasy adventures.", AgeGroupID = 3, CategoryID = 4 },
new Activity { ActivityId = 21, ActivityName = "Clay Sculpting", Description = "Sculpting figures from clay.", AgeGroupID = 3, CategoryID = 3 },
new Activity { ActivityId = 22, ActivityName = "Chess", Description = "Learning and playing chess.", AgeGroupID = 3, CategoryID = 6 },
new Activity { ActivityId = 23, ActivityName = "Jump Rope", Description = "Jumping rope and playing jump rope games.", AgeGroupID = 3, CategoryID = 7 },
new Activity { ActivityId = 24, ActivityName = "Scavenger Hunt", Description = "Organizing a scavenger hunt in the backyard.", AgeGroupID = 3, CategoryID = 8 },
new Activity { ActivityId = 25, ActivityName = "Robot Building", Description = "Building simple robots with Lego and motors.", AgeGroupID = 4, CategoryID = 2 },
new Activity { ActivityId = 26, ActivityName = "Watercolor Painting", Description = "Creating detailed paintings with watercolors.", AgeGroupID = 4, CategoryID = 3 },
new Activity { ActivityId = 27, ActivityName = "Fantasy Role-Playing", Description = "Engaging in complex fantasy role-playing games.", AgeGroupID = 4, CategoryID = 4 },
new Activity { ActivityId = 28, ActivityName = "Story Writing", Description = "Writing and illustrating short stories.", AgeGroupID = 4, CategoryID = 4 },
new Activity { ActivityId = 29, ActivityName = "Coding Games", Description = "Designing simple games using coding.", AgeGroupID = 4, CategoryID = 8 },
new Activity { ActivityId = 30, ActivityName = "Strategy Board Games", Description = "Playing strategy-based board games like Risk.", AgeGroupID = 4, CategoryID = 6 },
new Activity { ActivityId = 31, ActivityName = "Obstacle Challenges", Description = "Creating and overcoming physical obstacle challenges.", AgeGroupID = 4, CategoryID = 7 },
new Activity { ActivityId = 32, ActivityName = "Recycled Art", Description = "Creating art from recycled materials.", AgeGroupID = 4, CategoryID = 3 },
new Activity { ActivityId = 33, ActivityName = "Drama Skits", Description = "Writing and performing short skits.", AgeGroupID = 4, CategoryID = 1 }
      );
      modelBuilder.Entity<ActivityMaterial>().HasData(
          // Age Group 0-2 years
          new ActivityMaterial { ActivityId = 1, MaterialId = 5 },
          new ActivityMaterial { ActivityId = 1, MaterialId = 12 },
          new ActivityMaterial { ActivityId = 2, MaterialId = 1 },
          new ActivityMaterial { ActivityId = 3, MaterialId = 3 },
          new ActivityMaterial { ActivityId = 4, MaterialId = 11 },
          new ActivityMaterial { ActivityId = 4, MaterialId = 8 },
          new ActivityMaterial { ActivityId = 5, MaterialId = 14 },
          new ActivityMaterial { ActivityId = 6, MaterialId = 38 },
          new ActivityMaterial { ActivityId = 7, MaterialId = 46 },
          new ActivityMaterial { ActivityId = 8, MaterialId = 45 },
          new ActivityMaterial { ActivityId = 8, MaterialId = 46 },
          new ActivityMaterial { ActivityId = 8, MaterialId = 47 },
          // Age Group 3-5 years
          new ActivityMaterial { ActivityId = 9, MaterialId = 7 },
          new ActivityMaterial { ActivityId = 9, MaterialId = 25 },
          new ActivityMaterial { ActivityId = 9, MaterialId = 9 },
          new ActivityMaterial { ActivityId = 10, MaterialId = 6 },
          new ActivityMaterial { ActivityId = 11, MaterialId = 9 },
          new ActivityMaterial { ActivityId = 11, MaterialId = 10 },
          new ActivityMaterial { ActivityId = 12, MaterialId = 25 },
          new ActivityMaterial { ActivityId = 12, MaterialId = 35 },
          new ActivityMaterial { ActivityId = 13, MaterialId = 46 },
          new ActivityMaterial { ActivityId = 14, MaterialId = 6 },
          new ActivityMaterial { ActivityId = 15, MaterialId = 5 },
          new ActivityMaterial { ActivityId = 15, MaterialId = 38 },
          new ActivityMaterial { ActivityId = 16, MaterialId = 38 },
          // Age Group 6-8 years
          new ActivityMaterial { ActivityId = 17, MaterialId = 10 },
          new ActivityMaterial { ActivityId = 18, MaterialId = 43 },
          new ActivityMaterial { ActivityId = 18, MaterialId = 44 },
          new ActivityMaterial { ActivityId = 18, MaterialId = 27 },
          new ActivityMaterial { ActivityId = 18, MaterialId = 25 },
          new ActivityMaterial { ActivityId = 18, MaterialId = 26 },
          new ActivityMaterial { ActivityId = 18, MaterialId = 48 },
          new ActivityMaterial { ActivityId = 18, MaterialId = 49 },
          new ActivityMaterial { ActivityId = 18, MaterialId = 50 },
          new ActivityMaterial { ActivityId = 19, MaterialId = 33 },
          new ActivityMaterial { ActivityId = 20, MaterialId = 10 },
          new ActivityMaterial { ActivityId = 20, MaterialId = 25 },
          new ActivityMaterial { ActivityId = 20, MaterialId = 26 },
          new ActivityMaterial { ActivityId = 20, MaterialId = 27 },
          new ActivityMaterial { ActivityId = 21, MaterialId = 5 },
          new ActivityMaterial { ActivityId = 21, MaterialId = 4 },
          new ActivityMaterial { ActivityId = 22, MaterialId = 2 },
          new ActivityMaterial { ActivityId = 23, MaterialId = 33 },
          new ActivityMaterial { ActivityId = 24, MaterialId = 45 },
          new ActivityMaterial { ActivityId = 24, MaterialId = 46 },
          new ActivityMaterial { ActivityId = 25, MaterialId = 6 },
          new ActivityMaterial { ActivityId = 25, MaterialId = 39 },
          new ActivityMaterial { ActivityId = 26, MaterialId = 11 },
          new ActivityMaterial { ActivityId = 26, MaterialId = 8 },
          new ActivityMaterial { ActivityId = 26, MaterialId = 10 },
          new ActivityMaterial { ActivityId = 27, MaterialId = 35 },
          new ActivityMaterial { ActivityId = 27, MaterialId = 36 },
          new ActivityMaterial { ActivityId = 28, MaterialId = 10 },
          new ActivityMaterial { ActivityId = 28, MaterialId = 8 },
          new ActivityMaterial { ActivityId = 29, MaterialId = 51 },
          new ActivityMaterial { ActivityId = 30, MaterialId = 2 },
          new ActivityMaterial { ActivityId = 31, MaterialId = 45 },
          new ActivityMaterial { ActivityId = 31, MaterialId = 46 },
          new ActivityMaterial { ActivityId = 31, MaterialId = 38 },
          new ActivityMaterial { ActivityId = 32, MaterialId = 45 },
new ActivityMaterial { ActivityId = 32, MaterialId = 25 },
new ActivityMaterial { ActivityId = 32, MaterialId = 26 },
new ActivityMaterial { ActivityId = 32, MaterialId = 27 },
new ActivityMaterial { ActivityId = 33, MaterialId = 10 },
new ActivityMaterial { ActivityId = 33, MaterialId = 8 }

      // ... add all other mappings between activ6ties and materials
      );
      modelBuilder.Entity<User>().HasData(
    new User { UserID = 1, Username = "john_doe", Email = "john.doe@example.com" },
    new User { UserID = 2, Username = "jane_smith", Email = "jane.smith@example.com" }
);


    }



  }
}