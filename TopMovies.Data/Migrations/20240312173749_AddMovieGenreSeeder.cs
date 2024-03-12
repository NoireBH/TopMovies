using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class AddMovieGenreSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MovieGenres",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { 1, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") },
                    { 1, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") },
                    { 1, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") },
                    { 3, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") },
                    { 4, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") },
                    { 4, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") },
                    { 4, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") },
                    { 5, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") },
                    { 5, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") },
                    { 5, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") },
                    { 5, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") },
                    { 5, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") },
                    { 5, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") },
                    { 6, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") },
                    { 8, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") },
                    { 8, new Guid("506f4021-595b-4637-bba0-e2b88377549e") },
                    { 8, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") },
                    { 11, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") },
                    { 11, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") },
                    { 11, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") },
                    { 12, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") },
                    { 12, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") },
                    { 13, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 1, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 3, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 4, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 4, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 4, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 5, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 6, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 8, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 8, new Guid("506f4021-595b-4637-bba0-e2b88377549e") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 8, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 11, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 11, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 11, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 12, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 12, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") });

            migrationBuilder.DeleteData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreId", "MovieId" },
                keyValues: new object[] { 13, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") });
        }
    }
}
