using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LaunchApi.Migrations
{
    public partial class intital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Launches",
                columns: table => new
                {
                    LaunchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Mission = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Location = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    DaysToLaunch = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Launches", x => x.LaunchId);
                });

            migrationBuilder.InsertData(
                table: "Launches",
                columns: new[] { "LaunchId", "DaysToLaunch", "Location", "Mission" },
                values: new object[,]
                {
                    { 1, 5, "Kennedy Space Center", "Artemis" },
                    { 2, 6, "Vandenberg SFB", "Starlink-58 (3-4)" },
                    { 3, 11, "Cape Canaveral", "Starlink-59(4-20)" },
                    { 4, 13, "Guiana Space Centre", "Eutelsat Konnect VHTS" },
                    { 5, 13, "Pacific Spaceport Complex - A", "RS1 Flight 1" },
                    { 6, 14, "Kennedy Space Center", "Starlink (4-2)" },
                    { 7, 18, "Vandenberg SFB", "To the Black" },
                    { 8, 29, "Baikonur Cosmodrome", "Soyuz MS-22" },
                    { 9, 32, "Vandenberg SFB", "NROL-91" },
                    { 10, 30, "Rocket Lab Launch Complex", "The Owl Spreads Its Wings" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Launches");
        }
    }
}
