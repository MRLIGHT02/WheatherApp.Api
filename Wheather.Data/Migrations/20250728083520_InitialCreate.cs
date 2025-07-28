using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wheather.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WheatherModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CityUniqueCode = table.Column<string>(type: "TEXT", nullable: false),
                    CityName = table.Column<string>(type: "TEXT", nullable: false),
                    DateAndTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TemperatureFahrenheit = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WheatherModels", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WheatherModels");
        }
    }
}
