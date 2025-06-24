using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PCGamesPartials.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PCGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCGames", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PCGames",
                columns: new[] { "Id", "Description", "Genre", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Futuristisk open-world shooter.", "RPG", "/images/cyberpunk.jpg", 599m, "Cyberpunk 2077" },
                    { 2, "Fantasyvärld med tuffa bossar.", "Action RPG", "/images/eldenring.jpg", 699m, "Elden Ring" },
                    { 3, "Taktisk 5v5 shooter.", "FPS", "/images/valorant.jpg", 0m, "Valorant" },
                    { 4, "Episkt äventyr med Geralt.", "RPG", "/images/witcher3.jpg", 299m, "The Witcher 3" },
                    { 5, "Klassisk tävlingsskjutare.", "FPS", "/images/cs2.jpg", 0m, "CS2" },
                    { 6, "Bygg, utforska, överlev.", "Sandbox", "/images/minecraft.jpg", 269m, "Minecraft" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PCGames");
        }
    }
}
