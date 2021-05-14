using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAirport.Migrations
{
    public partial class CodeForAirports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_flights_airports_arrival_code",
                table: "flights");

            migrationBuilder.DropForeignKey(
                name: "fk_flights_airports_departure_code",
                table: "flights");

            migrationBuilder.RenameColumn(
                name: "departure_code",
                table: "flights",
                newName: "departure_code_code");

            migrationBuilder.RenameColumn(
                name: "arrival_code",
                table: "flights",
                newName: "departure_code1");

            migrationBuilder.RenameIndex(
                name: "ix_flights_departure_code",
                table: "flights",
                newName: "ix_flights_departure_code_code");

            migrationBuilder.RenameIndex(
                name: "ix_flights_arrival_code",
                table: "flights",
                newName: "ix_flights_departure_code1");

            migrationBuilder.AddColumn<string>(
                name: "arrival_code1",
                table: "flights",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "arrival_code_code",
                table: "flights",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_flights_arrival_code_code",
                table: "flights",
                column: "arrival_code_code");

            migrationBuilder.CreateIndex(
                name: "ix_flights_arrival_code1",
                table: "flights",
                column: "arrival_code1");

            migrationBuilder.AddForeignKey(
                name: "fk_flights_airports_arrival_code_code",
                table: "flights",
                column: "arrival_code_code",
                principalTable: "airports",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_flights_airports_arrival_code1",
                table: "flights",
                column: "arrival_code1",
                principalTable: "airports",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_flights_airports_departure_code_code",
                table: "flights",
                column: "departure_code_code",
                principalTable: "airports",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_flights_airports_departure_code1",
                table: "flights",
                column: "departure_code1",
                principalTable: "airports",
                principalColumn: "code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_flights_airports_arrival_code_code",
                table: "flights");

            migrationBuilder.DropForeignKey(
                name: "fk_flights_airports_arrival_code1",
                table: "flights");

            migrationBuilder.DropForeignKey(
                name: "fk_flights_airports_departure_code_code",
                table: "flights");

            migrationBuilder.DropForeignKey(
                name: "fk_flights_airports_departure_code1",
                table: "flights");

            migrationBuilder.DropIndex(
                name: "ix_flights_arrival_code_code",
                table: "flights");

            migrationBuilder.DropIndex(
                name: "ix_flights_arrival_code1",
                table: "flights");

            migrationBuilder.DropColumn(
                name: "arrival_code1",
                table: "flights");

            migrationBuilder.DropColumn(
                name: "arrival_code_code",
                table: "flights");

            migrationBuilder.RenameColumn(
                name: "departure_code_code",
                table: "flights",
                newName: "departure_code");

            migrationBuilder.RenameColumn(
                name: "departure_code1",
                table: "flights",
                newName: "arrival_code");

            migrationBuilder.RenameIndex(
                name: "ix_flights_departure_code1",
                table: "flights",
                newName: "ix_flights_arrival_code");

            migrationBuilder.RenameIndex(
                name: "ix_flights_departure_code_code",
                table: "flights",
                newName: "ix_flights_departure_code");

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
    }
}
