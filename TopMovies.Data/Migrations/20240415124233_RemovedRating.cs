using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class RemovedRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Movies",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("075af806-fb6f-476d-804f-baecbd15bdd3"),
                column: "Rating",
                value: 9.0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("13b84726-1968-4206-9f4b-856a4ba9998a"),
                column: "Rating",
                value: 7.5999999999999996);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da"),
                column: "Rating",
                value: 8.9000000000000004);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2ca61990-fe17-483c-863d-442ee4c0acad"),
                column: "Rating",
                value: 9.3000000000000007);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("30da4459-9475-404d-92fb-9124cff7cfa6"),
                column: "Rating",
                value: 9.1999999999999993);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173"),
                column: "Rating",
                value: 7.7999999999999998);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("506f4021-595b-4637-bba0-e2b88377549e"),
                column: "Rating",
                value: 7.2999999999999998);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4"),
                column: "Rating",
                value: 8.0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef"),
                column: "Rating",
                value: 6.9000000000000004);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6"),
                column: "Rating",
                value: 5.5);
        }
    }
}
