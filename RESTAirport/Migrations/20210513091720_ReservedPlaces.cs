using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MyAirport.Migrations
{
    public partial class ReservedPlaces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_flights_cities_finish_city_id",
                table: "flights");

            migrationBuilder.DropForeignKey(
                name: "fk_flights_cities_start_city_id",
                table: "flights");

            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropIndex(
                name: "ix_flights_finish_city_id",
                table: "flights");

            migrationBuilder.DropIndex(
                name: "ix_flights_start_city_id",
                table: "flights");

            migrationBuilder.DropColumn(
                name: "finish_city_id",
                table: "flights");

            migrationBuilder.DropColumn(
                name: "start_city_id",
                table: "flights");

            migrationBuilder.AddColumn<string>(
                name: "arrival_code",
                table: "flights",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "departure_code",
                table: "flights",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "reserved_places",
                table: "flights",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "airports",
                columns: table => new
                {
                    code = table.Column<string>(type: "text", nullable: false),
                    title = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_airports", x => x.code);
                });

            migrationBuilder.CreateIndex(
                name: "ix_flights_arrival_code",
                table: "flights",
                column: "arrival_code");

            migrationBuilder.CreateIndex(
                name: "ix_flights_departure_code",
                table: "flights",
                column: "departure_code");

            migrationBuilder.AddForeignKey(
                name: "fk_flights_airports_arrival_code",
                table: "flights",
                column: "arrival_code",
                principalTable: "airports",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_flights_airports_departure_code",
                table: "flights",
                column: "departure_code",
                principalTable: "airports",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_flights_airports_arrival_code",
                table: "flights");

            migrationBuilder.DropForeignKey(
                name: "fk_flights_airports_departure_code",
                table: "flights");

            migrationBuilder.DropTable(
                name: "airports");

            migrationBuilder.DropIndex(
                name: "ix_flights_arrival_code",
                table: "flights");

            migrationBuilder.DropIndex(
                name: "ix_flights_departure_code",
                table: "flights");

            migrationBuilder.DropColumn(
                name: "arrival_code",
                table: "flights");

            migrationBuilder.DropColumn(
                name: "departure_code",
                table: "flights");

            migrationBuilder.DropColumn(
                name: "reserved_places",
                table: "flights");

            migrationBuilder.AddColumn<int>(
                name: "finish_city_id",
                table: "flights",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "start_city_id",
                table: "flights",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cities", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "ix_flights_finish_city_id",
                table: "flights",
                column: "finish_city_id");

            migrationBuilder.CreateIndex(
                name: "ix_flights_start_city_id",
                table: "flights",
                column: "start_city_id");

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
    }
}
