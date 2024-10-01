using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventory.Migrations
{
    /// <inheritdoc />
    public partial class AddLookupTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lookups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lookups", x => x.Id);
                });
            migrationBuilder.InsertData(
              table: "Lookups",
              columns: new[] { "Name", "Description" },
              values: new object[,]
              {
                { "North-West Corner", "Location 1" },
                { "North-Center", "Location 2" },
                { "North-East Corner", "Location 3" },
                { "West Wall", "Location 4" },
                { "Center of Room", "Location 5" },
                { "East Wall", "Location 6" },
                { "South-West Corner", "Location 7" },
                { "South-Center", "Location 8" },
                { "South-East Corner", "Location 9" }
              });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lookups");
        }
    }
}
