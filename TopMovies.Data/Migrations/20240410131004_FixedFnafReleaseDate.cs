using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class FixedFnafReleaseDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6"),
                column: "ReleaseDate",
                value: new DateTime(2024, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6"),
                column: "ReleaseDate",
                value: new DateTime(1994, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
