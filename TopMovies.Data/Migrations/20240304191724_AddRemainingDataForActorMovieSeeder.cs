using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class AddRemainingDataForActorMovieSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ActorMovies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 7, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") },
                    { 8, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") },
                    { 9, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") },
                    { 10, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") },
                    { 11, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") },
                    { 12, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") },
                    { 13, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") },
                    { 14, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") },
                    { 28, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") },
                    { 2, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") },
                    { 3, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") },
                    { 4, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") },
                    { 5, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") },
                    { 21, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") },
                    { 22, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") },
                    { 23, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") },
                    { 18, new Guid("506f4021-595b-4637-bba0-e2b88377549e") },
                    { 19, new Guid("506f4021-595b-4637-bba0-e2b88377549e") },
                    { 20, new Guid("506f4021-595b-4637-bba0-e2b88377549e") },
                    { 21, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") },
                    { 26, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") },
                    { 27, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") },
                    { 21, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") },
                    { 24, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") },
                    { 25, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") },
                    { 15, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") },
                    { 16, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") },
                    { 17, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "DateOfBirth", "Description", "ImageUrl", "Name" },
                values: new object[] { 6, new DateTime(1943, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "With a singularly nebulous background, which, by his account, included stints as a Las Vegas nightclub emcee, radio personality and jewelry tycoon, and with comparatively little acting experience, Gianni Russo won the role of Carlo Rizzi in The Godfather (1972) on the basis of his screen test. Since then, Russo has remained busy as an actor, mostly playing assorted \"wiseguys\" and Mafia types. He appeared again with Marlon Brando in a small role in The Freshman (1990) where Brando parodied his Don Corleone role to good effect.", "Gianni Russo", "Gianni Russo" });

            migrationBuilder.InsertData(
                table: "ActorMovies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 6, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 7, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 8, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 9, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 10, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 11, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 12, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 13, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 14, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 28, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 5, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 6, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 21, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 22, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 23, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 18, new Guid("506f4021-595b-4637-bba0-e2b88377549e") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 19, new Guid("506f4021-595b-4637-bba0-e2b88377549e") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 20, new Guid("506f4021-595b-4637-bba0-e2b88377549e") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 21, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 26, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 27, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 21, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 24, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 25, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 15, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 16, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") });

            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 17, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
