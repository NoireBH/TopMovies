using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class AddedActorMovieCharacterSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 5, 6 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 28, 15 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 15, 16 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 16, 17 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 17, 18 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 18, 19 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 19, 20 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 20, 21 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 21, 22 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 22, 23 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 23, 24 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 24, 25 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 21, 26 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 25, 27 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 21, 28 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 26, 29 });

            migrationBuilder.DeleteData(
                table: "ActorMovieCharacters",
                keyColumns: new[] { "ActorId", "MovieCharacterId" },
                keyValues: new object[] { 27, 30 });
        }
    }
}
