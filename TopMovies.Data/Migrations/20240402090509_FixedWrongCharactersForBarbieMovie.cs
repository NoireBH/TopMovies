using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class FixedWrongCharactersForBarbieMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 28,
                column: "MovieId",
                value: new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4"));

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 29,
                column: "MovieId",
                value: new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4"));

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 30,
                column: "MovieId",
                value: new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 28,
                column: "MovieId",
                value: new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef"));

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 29,
                column: "MovieId",
                value: new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef"));

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 30,
                column: "MovieId",
                value: new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef"));
        }
    }
}
