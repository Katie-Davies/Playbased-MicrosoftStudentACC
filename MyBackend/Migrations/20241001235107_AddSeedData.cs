using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyBackend.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgeGroups",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Range = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeGroups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeGroupID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_Activities_AgeGroups_AgeGroupID",
                        column: x => x.AgeGroupID,
                        principalTable: "AgeGroups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Activities_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivityMaterials",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityMaterials", x => new { x.ActivityId, x.MaterialId });
                    table.ForeignKey(
                        name: "FK_ActivityMaterials_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityMaterials_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    FavouriteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.FavouriteID);
                    table.ForeignKey(
                        name: "FK_Favourites_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favourites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AgeGroups",
                columns: new[] { "id", "Range" },
                values: new object[,]
                {
                    { 1, "0-2 years" },
                    { 2, "3-5 years" },
                    { 3, "6-8 years" },
                    { 4, "9-12 years" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Imaginative Play" },
                    { 2, "Construction" },
                    { 3, "Art" },
                    { 4, "Fantasy" },
                    { 5, "Sensory" },
                    { 6, "Games with Rules" },
                    { 7, "Physical" },
                    { 8, "Exploration" }
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialID", "MaterialName" },
                values: new object[,]
                {
                    { 1, "Blocks" },
                    { 2, "Puzzles" },
                    { 3, "Books" },
                    { 4, "Art Supplies" },
                    { 5, "Dough" },
                    { 6, "Lego" },
                    { 7, "Cardboard" },
                    { 8, "Markers" },
                    { 9, "Stickers" },
                    { 10, "Paper" },
                    { 11, "Paint" },
                    { 12, "Cornflour" },
                    { 13, "Balloons" },
                    { 14, "Bubbles" },
                    { 15, "Rice" },
                    { 16, "Pasta" },
                    { 17, "Glitter" },
                    { 18, "Pom Poms" },
                    { 19, "Pipe Cleaners" },
                    { 20, "Cotton Balls" },
                    { 21, "Feathers" },
                    { 22, "Buttons" },
                    { 23, "Beads" },
                    { 24, "Sequins" },
                    { 25, "Glue" },
                    { 26, "Tape" },
                    { 27, "Scissors" },
                    { 28, "Hole Punch" },
                    { 29, "Ruler" },
                    { 30, "Stapler" },
                    { 31, "Paper Clips" },
                    { 32, "Rubber Bands" },
                    { 33, "String" },
                    { 34, "Yarn" },
                    { 35, "Fabric" },
                    { 36, "Felt" },
                    { 37, "Foam" },
                    { 38, "Wood" },
                    { 39, "Plastic" },
                    { 40, "Metal" },
                    { 41, "Glass" },
                    { 42, "Ceramic" },
                    { 43, "Paper Mache" },
                    { 44, "Cardboard" },
                    { 45, "Recycled Materials" },
                    { 46, "Natural Materials" },
                    { 47, "Water" },
                    { 48, "Baking soda" },
                    { 49, "Vinegar" },
                    { 50, "Food coloring" },
                    { 51, "Computer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "Username" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "john_doe" },
                    { 2, "jane.smith@example.com", "jane_smith" }
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "ActivityId", "ActivityName", "AgeGroupID", "CategoryID", "Description", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "Cloud Dough", 1, 5, "Making and playing with cloud dough", "" },
                    { 2, "Stacking Blocks", 1, 2, "Stacking different types of blocks.", "" },
                    { 3, "Animal Sounds", 1, 4, "Identifying animal sounds from a book.", "" },
                    { 4, "Finger Painting", 1, 3, "Creating art using finger paints.", "" },
                    { 5, "Bubble Wrap Play", 1, 5, "Popping bubble wrap for sensory play.", "" },
                    { 6, "Water Play", 1, 7, "Splashing and playing with water.", "" },
                    { 7, "Sensory Bottles", 1, 5, "Exploring sensory bottles filled with different materials.", "" },
                    { 8, "Pretend Cooking", 1, 1, "Pretend cooking with toy food.", "" },
                    { 9, "Making Dragons", 2, 4, "Crafting dragons out of toilet roll cardboard.", "" },
                    { 10, "Building with Lego", 2, 2, "Creating structures with Lego.", "" },
                    { 11, "Sticker Collage", 2, 3, "Making a collage with various stickers.", "" },
                    { 12, "Dress-Up Play", 2, 1, "Engaging in dress-up and role play.", "" },
                    { 13, "Nature Walk", 2, 8, "Collecting natural items during a nature walk.", "" },
                    { 14, "Lego Castle", 2, 2, "Building a castle with Lego.", "" },
                    { 15, "Making Pizza", 2, 1, "Pretend making pizza with play dough.", "" },
                    { 16, "Obstacle Course", 2, 7, "Navigating a simple obstacle course.", "" },
                    { 17, "Origami Animals", 3, 3, "Folding paper to create animal shapes.", "" },
                    { 18, "Volcano Experiment", 3, 8, "Creating a baking soda and vinegar volcano.", "" },
                    { 19, "Relay Races", 3, 6, "Participating in relay races with rules.", "" },
                    { 20, "Fantasy Map Making", 3, 4, "Creating maps for fantasy adventures.", "" },
                    { 21, "Clay Sculpting", 3, 3, "Sculpting figures from clay.", "" },
                    { 22, "Chess", 3, 6, "Learning and playing chess.", "" },
                    { 23, "Jump Rope", 3, 7, "Jumping rope and playing jump rope games.", "" },
                    { 24, "Scavenger Hunt", 3, 8, "Organizing a scavenger hunt in the backyard.", "" },
                    { 25, "Robot Building", 4, 2, "Building simple robots with Lego and motors.", "" },
                    { 26, "Watercolor Painting", 4, 3, "Creating detailed paintings with watercolors.", "" },
                    { 27, "Fantasy Role-Playing", 4, 4, "Engaging in complex fantasy role-playing games.", "" },
                    { 28, "Story Writing", 4, 4, "Writing and illustrating short stories.", "" },
                    { 29, "Coding Games", 4, 8, "Designing simple games using coding.", "" },
                    { 30, "Strategy Board Games", 4, 6, "Playing strategy-based board games like Risk.", "" },
                    { 31, "Obstacle Challenges", 4, 7, "Creating and overcoming physical obstacle challenges.", "" },
                    { 32, "Recycled Art", 4, 3, "Creating art from recycled materials.", "" },
                    { 33, "Drama Skits", 4, 1, "Writing and performing short skits.", "" }
                });

            migrationBuilder.InsertData(
                table: "ActivityMaterials",
                columns: new[] { "ActivityId", "MaterialId" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 1, 12 },
                    { 2, 1 },
                    { 3, 3 },
                    { 4, 8 },
                    { 4, 11 },
                    { 5, 14 },
                    { 6, 38 },
                    { 7, 46 },
                    { 8, 45 },
                    { 8, 46 },
                    { 8, 47 },
                    { 9, 7 },
                    { 9, 9 },
                    { 9, 25 },
                    { 10, 6 },
                    { 11, 9 },
                    { 11, 10 },
                    { 12, 25 },
                    { 12, 35 },
                    { 13, 46 },
                    { 14, 6 },
                    { 15, 5 },
                    { 15, 38 },
                    { 16, 38 },
                    { 17, 10 },
                    { 18, 25 },
                    { 18, 26 },
                    { 18, 27 },
                    { 18, 43 },
                    { 18, 44 },
                    { 18, 48 },
                    { 18, 49 },
                    { 18, 50 },
                    { 19, 33 },
                    { 20, 10 },
                    { 20, 25 },
                    { 20, 26 },
                    { 20, 27 },
                    { 21, 4 },
                    { 21, 5 },
                    { 22, 2 },
                    { 23, 33 },
                    { 24, 45 },
                    { 24, 46 },
                    { 25, 6 },
                    { 25, 39 },
                    { 26, 8 },
                    { 26, 10 },
                    { 26, 11 },
                    { 27, 35 },
                    { 27, 36 },
                    { 28, 8 },
                    { 28, 10 },
                    { 29, 51 },
                    { 30, 2 },
                    { 31, 38 },
                    { 31, 45 },
                    { 31, 46 },
                    { 32, 25 },
                    { 32, 26 },
                    { 32, 27 },
                    { 32, 45 },
                    { 33, 8 },
                    { 33, 10 }
                });

            migrationBuilder.InsertData(
                table: "Favourites",
                columns: new[] { "FavouriteID", "ActivityId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_AgeGroupID",
                table: "Activities",
                column: "AgeGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_CategoryID",
                table: "Activities",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityMaterials_MaterialId",
                table: "ActivityMaterials",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_ActivityId",
                table: "Favourites",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_UserId",
                table: "Favourites",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityMaterials");

            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AgeGroups");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
