using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAirport.Migrations
{
    public partial class ChangeRowNamesLast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "places",
                table: "flights",
                newName: "places_count");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "places_count",
                table: "flights",
                newName: "places");
        }
    }
}
