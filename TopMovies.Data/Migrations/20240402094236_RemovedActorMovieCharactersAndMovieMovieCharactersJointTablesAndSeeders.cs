using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class RemovedActorMovieCharactersAndMovieMovieCharactersJointTablesAndSeeders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovieCharacters");

            migrationBuilder.DropTable(
                name: "MovieMovieCharacters");

            migrationBuilder.AddColumn<int>(
                name: "ActorId1",
                table: "MovieCharacters",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MovieId1",
                table: "MovieCharacters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovieCharacters_ActorId1",
                table: "MovieCharacters",
                column: "ActorId1");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCharacters_MovieId1",
                table: "MovieCharacters",
                column: "MovieId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCharacters_Actors_ActorId1",
                table: "MovieCharacters",
                column: "ActorId1",
                principalTable: "Actors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieCharacters_Movies_MovieId1",
                table: "MovieCharacters",
                column: "MovieId1",
                principalTable: "Movies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieCharacters_Actors_ActorId1",
                table: "MovieCharacters");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieCharacters_Movies_MovieId1",
                table: "MovieCharacters");

            migrationBuilder.DropIndex(
                name: "IX_MovieCharacters_ActorId1",
                table: "MovieCharacters");

            migrationBuilder.DropIndex(
                name: "IX_MovieCharacters_MovieId1",
                table: "MovieCharacters");

            migrationBuilder.DropColumn(
                name: "ActorId1",
                table: "MovieCharacters");

            migrationBuilder.DropColumn(
                name: "MovieId1",
                table: "MovieCharacters");

            migrationBuilder.CreateTable(
                name: "ActorMovieCharacters",
                columns: table => new
                {
                    MovieCharacterId = table.Column<int>(type: "int", nullable: false),
                    ActorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovieCharacters", x => new { x.MovieCharacterId, x.ActorId });
                    table.ForeignKey(
                        name: "FK_ActorMovieCharacters_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovieCharacters_MovieCharacters_MovieCharacterId",
                        column: x => x.MovieCharacterId,
                        principalTable: "MovieCharacters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieMovieCharacters",
                columns: table => new
                {
                    MovieCharacterId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieMovieCharacters", x => new { x.MovieCharacterId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_MovieMovieCharacters_MovieCharacters_MovieCharacterId",
                        column: x => x.MovieCharacterId,
                        principalTable: "MovieCharacters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieMovieCharacters_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ActorMovieCharacters",
                columns: new[] { "ActorId", "MovieCharacterId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 1, 2 },
                    { 3, 3 },
                    { 6, 4 },
                    { 4, 5 },
                    { 5, 6 },
                    { 7, 7 },
                    { 8, 8 },
                    { 9, 9 },
                    { 10, 10 },
                    { 11, 11 },
                    { 12, 12 },
                    { 13, 13 },
                    { 14, 14 },
                    { 28, 15 },
                    { 15, 16 },
                    { 16, 17 },
                    { 17, 18 },
                    { 18, 19 },
                    { 19, 20 },
                    { 20, 21 },
                    { 21, 22 },
                    { 22, 23 },
                    { 23, 24 },
                    { 24, 25 },
                    { 21, 26 },
                    { 25, 27 },
                    { 21, 28 },
                    { 26, 29 },
                    { 27, 30 }
                });

            migrationBuilder.InsertData(
                table: "MovieMovieCharacters",
                columns: new[] { "MovieCharacterId", "MovieId" },
                values: new object[,]
                {
                    { 1, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") },
                    { 2, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") },
                    { 3, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") },
                    { 4, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") },
                    { 5, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") },
                    { 6, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") },
                    { 7, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") },
                    { 8, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") },
                    { 9, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") },
                    { 10, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") },
                    { 10, new Guid("506f4021-595b-4637-bba0-e2b88377549e") },
                    { 11, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") }
                });

            migrationBuilder.InsertData(
                table: "MovieMovieCharacters",
                columns: new[] { "MovieCharacterId", "MovieId" },
                values: new object[,]
                {
                    { 12, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") },
                    { 13, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") },
                    { 14, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") },
                    { 15, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") },
                    { 16, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") },
                    { 17, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") },
                    { 18, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") },
                    { 20, new Guid("506f4021-595b-4637-bba0-e2b88377549e") },
                    { 21, new Guid("506f4021-595b-4637-bba0-e2b88377549e") },
                    { 22, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") },
                    { 23, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") },
                    { 24, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") },
                    { 25, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") },
                    { 26, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") },
                    { 27, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") },
                    { 28, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") },
                    { 29, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") },
                    { 30, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovieCharacters_ActorId",
                table: "ActorMovieCharacters",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieMovieCharacters_MovieId",
                table: "MovieMovieCharacters",
                column: "MovieId");
        }
    }
}
