using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAirport.Migrations
{
    public partial class ChangeRowNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_flights_citys_finish_city_id",
                table: "flights");

            migrationBuilder.DropForeignKey(
                name: "fk_flights_citys_start_city_id",
                table: "flights");

            migrationBuilder.DropPrimaryKey(
                name: "pk_citys",
                table: "citys");

            migrationBuilder.RenameTable(
                name: "citys",
                newName: "cities");

            migrationBuilder.AddPrimaryKey(
                name: "pk_cities",
                table: "cities",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_flights_cities_finish_city_id",
                table: "flights",
                column: "finish_city_id",
                principalTable: "cities",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_flights_cities_start_city_id",
                table: "flights",
                column: "start_city_id",
                principalTable: "cities",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_flights_cities_finish_city_id",
                table: "flights");

            migrationBuilder.DropForeignKey(
                name: "fk_flights_cities_start_city_id",
                table: "flights");

            migrationBuilder.DropPrimaryKey(
                name: "pk_cities",
                table: "cities");

            migrationBuilder.RenameTable(
                name: "cities",
                newName: "citys");

            migrationBuilder.AddPrimaryKey(
                name: "pk_citys",
                table: "citys",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_flights_citys_finish_city_id",
                table: "flights",
                column: "finish_city_id",
                principalTable: "citys",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_flights_citys_start_city_id",
                table: "flights",
                column: "start_city_id",
                principalTable: "citys",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
