using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class PhotoSeedTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "ImageURl", "MovieId" },
                values: new object[] { 1, "https://m.media-amazon.com/images/M/MV5BMTM0NjUxMDk5MF5BMl5BanBnXkFtZTcwNDMxNDY3Mw@@._V1_FMjpg_UX1800_.jpg", new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "ImageURl", "MovieId" },
                values: new object[] { 2, "https://m.media-amazon.com/images/M/MV5BMTM0NjUxMDk5MF5BMl5BanBnXkFtZTcwNDMxNDY3Mw@@._V1_FMjpg_UX1800_.jpg", new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "ImageURl", "MovieId" },
                values: new object[] { 3, "https://m.media-amazon.com/images/M/MV5BMTM0NjUxMDk5MF5BMl5BanBnXkFtZTcwNDMxNDY3Mw@@._V1_FMjpg_UX1800_.jpg", new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
