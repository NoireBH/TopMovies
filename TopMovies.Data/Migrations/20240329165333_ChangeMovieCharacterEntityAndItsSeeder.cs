using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class ChangeMovieCharacterEntityAndItsSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActorId",
                table: "MovieCharacters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "MovieId",
                table: "MovieCharacters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 2, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 1, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 3, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 6, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 4, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 5, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 7, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 8, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 9, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 10, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 11, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 12, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 13, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 14, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 28, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 15, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 16, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 17, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 18, new Guid("506f4021-595b-4637-bba0-e2b88377549e") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 19, new Guid("506f4021-595b-4637-bba0-e2b88377549e") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 20, new Guid("506f4021-595b-4637-bba0-e2b88377549e") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 21, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 22, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 23, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 24, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 21, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 25, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 21, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 26, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") });

            migrationBuilder.UpdateData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 27, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") });

            migrationBuilder.CreateIndex(
                name: "IX_MovieCharacters_ActorId",
                table: "MovieCharacters",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCharacters_MovieId",
                table: "MovieCharacters",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCharacters_Actors_ActorId",
                table: "MovieCharacters",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCharacters_Movies_MovieId",
                table: "MovieCharacters",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieCharacters_Actors_ActorId",
                table: "MovieCharacters");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCharacters_Movies_MovieId",
                table: "MovieCharacters");

            migrationBuilder.DropIndex(
                name: "IX_MovieCharacters_ActorId",
                table: "MovieCharacters");

            migrationBuilder.DropIndex(
                name: "IX_MovieCharacters_MovieId",
                table: "MovieCharacters");

            migrationBuilder.DropColumn(
                name: "ActorId",
                table: "MovieCharacters");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "MovieCharacters");
        }
    }
}
