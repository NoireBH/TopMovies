using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class ChangedRelationshipOfMoviePhotoToOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MoviePhotos");

            migrationBuilder.AddColumn<Guid>(
                name: "MovieId",
                table: "Photos",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MovieCharacters",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "MovieCharacters",
                columns: new[] { "Id", "Age", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 0, "https://m.media-amazon.com/images/M/MV5BZTZlNGQ5MjAtZmE3OC00MWFlLWE2MWItYWY2ZTIwOTZlNDYxXkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg", "Andy Dufresne" },
                    { 2, 0, "https://m.media-amazon.com/images/M/MV5BZGVmZjg5NTEtMjJhNS00OWJjLThjOTYtZTk0NjUwMjA3MjkyXkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg", "Ellis Boyd 'Red' Redding" },
                    { 3, 0, "https://m.media-amazon.com/images/M/MV5BODUzYTVhM2EtODVjOS00ODFkLWFjNjItNGEzOWFmNTgyZDI2XkEyXkFqcGdeQXVyOTc5MDI5NjE@._V1_FMjpg_UX600_.jpg", "Captain Hadley" },
                    { 4, 0, "https://m.media-amazon.com/images/M/MV5BYjhiMGExMmYtM2RlOC00OTFmLWFmODQtMjkxMjZkNjk0ZTIzXkEyXkFqcGdeQXVyMTIwODk1NTQ@._V1_FMjpg_UX600_.jpg", "Carlo Rizzi" },
                    { 5, 0, "https://m.media-amazon.com/images/M/MV5BMDhkYzhiYjEtMTQwYy00MTdmLTlkOTAtYTk1YmMyYmE5NDVmXkEyXkFqcGdeQXVyMDc2NTEzMw@@._V1_FMjpg_UY337_.jpg", "Michael Corleone" },
                    { 6, 0, "https://m.media-amazon.com/images/M/MV5BYmMyZTNiZjItMjZkOC00NDRkLTg5YTEtZDFjODBlODliYjYxXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg", "Kay Adams" },
                    { 7, 0, "https://m.media-amazon.com/images/M/MV5BYmMyZTNiZjItMjZkOC00NDRkLTg5YTEtZDFjODBlODliYjYxXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg", "Bruce Wayne, Batman" },
                    { 8, 0, "https://m.media-amazon.com/images/M/MV5BMjA5ODU3NTI0Ml5BMl5BanBnXkFtZTcwODczMTk2Mw@@._V1_FMjpg_UX2048_.jpg", "Joker" },
                    { 9, 0, "https://m.media-amazon.com/images/M/MV5BY2FkYmExNTMtYTkxNS00NzA0LTliYTktOTNjNjEwZmRlMTU2XkEyXkFqcGdeQXVyNDIyNjA2MTk@._V1_.jpgg", "Scarecrow" },
                    { 10, 0, "https://m.media-amazon.com/images/M/MV5BMTUxMDgyMTg3N15BMl5BanBnXkFtZTcwMDY2OTYwNA@@._V1_FMjpg_UX2048_.jpg", "Adam" },
                    { 11, 0, "https://m.media-amazon.com/images/M/MV5BZDdmMDA3NzItYmNlYi00NjU3LWJlZGYtMDYxNzg0OWUzNDJjXkEyXkFqcGdeQXVyNjQ4ODE4MzQ@._V1_FMjpg_UX1280_.jpg", "Dr. Lawrence Gordon" },
                    { 12, 0, "https://m.media-amazon.com/images/M/MV5BMTM0MzIwMTI5OV5BMl5BanBnXkFtZTcwOTg1NjAxNQ@@._V1_FMjpg_UX2048_.jpg", "Jigsaw" },
                    { 13, 0, "https://m.media-amazon.com/images/M/MV5BYTMzOWFiMTEtZGFjOS00OWEyLTlhYmEtOGRlZmNkZjhhNmJhXkEyXkFqcGdeQXVyNDIyNjA2MTk@._V1_FMjpg_UX2048_.jpg", "Vincent Vega" },
                    { 14, 0, "https://m.media-amazon.com/images/M/MV5BNzg1MTgwMTUzM15BMl5BanBnXkFtZTcwNjA0MzU5Ng@@._V1_FMjpg_UX2048_.jpg", "Mia Wallace" },
                    { 15, 0, "https://m.media-amazon.com/images/M/MV5BMjIwNTg0Mjc4Nl5BMl5BanBnXkFtZTcwODAzNDY3Mw@@._V1_FMjpg_UX660_.jpg", "Jules Winnfield" },
                    { 16, 0, "https://m.media-amazon.com/images/M/MV5BZjkwZTllMzgtMDAyOC00MDgzLWE4NmUtOTZmNzQ5NTY1NGIzXkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_FMjpg_UX1920_.jpg", "Mike" },
                    { 17, 0, "https://m.media-amazon.com/images/M/MV5BNzdkNjBmYzItMDZjMC00ZTFkLThmYWYtNDY5OWNiNTZlZjViXkEyXkFqcGdeQXVyMTY2MDI5OTg3._V1_FMjpg_UX1170_.jpg", "Vanessa" },
                    { 18, 0, "https://m.media-amazon.com/images/M/MV5BMzc1N2M0MWQtZTQ3NS00MmVmLWE1NDctOTg5MWQ0ZmEyMjk2XkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_FMjpg_UX1920_.jpg", "William Afton" },
                    { 19, 0, "https://m.media-amazon.com/images/M/MV5BMTg1NTU5NTgwOV5BMl5BanBnXkFtZTgwMTQ1NzMzMzI@._V1_FMjpg_UX1280_.jpg", "Pennywise" },
                    { 20, 0, "https://m.media-amazon.com/images/M/MV5BMTk2Nzg4NzUyMF5BMl5BanBnXkFtZTgwNDM1NzMzMzI@._V1_FMjpg_UX2048_.jpg", "Richie Tozier" },
                    { 21, 0, "https://m.media-amazon.com/images/M/MV5BMjE2MTg2OTM0Nl5BMl5BanBnXkFtZTgwNTM1NzMzMzI@._V1_FMjpg_UX2048_.jpg", "Bill Denbrough" },
                    { 22, 0, "https://m.media-amazon.com/images/M/MV5BNTM1NDk2OTE3M15BMl5BanBnXkFtZTcwMTM1NTgxNQ@@._V1_FMjpg_UX2048_.jpg", "Driver" },
                    { 23, 0, "https://m.media-amazon.com/images/M/MV5BNDgwMDMxMzQ5MF5BMl5BanBnXkFtZTcwMTEwMDk3NQ@@._V1_FMjpg_UX2048_.jpg", "Shannon" },
                    { 24, 0, "https://m.media-amazon.com/images/M/MV5BMTc2NTI1MzU5NF5BMl5BanBnXkFtZTcwMDAwMDk3NQ@@._V1_FMjpg_UX2048_.jpg", "Irene" },
                    { 25, 0, "https://m.media-amazon.com/images/M/MV5BZTM1NzVmZTItYmU0Zi00ODVmLWE4MWQtZTFlMzRiZmMxN2I4XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_FMjpg_UY5791_.jpg", "Barbie" },
                    { 26, 0, "https://m.media-amazon.com/images/M/MV5BMmY1NjBlNWEtZjNlZS00YmY3LWE5MTAtOWE3ZjAzYmQ3OTJjXkEyXkFqcGdeQXVyODk4OTc3MTY@._V1_FMjpg_UY4976_.jpg", "Ken" },
                    { 27, 0, "https://m.media-amazon.com/images/M/MV5BMDE1ZjJmMTMtYmJlZi00N2VjLWFkMmMtZTNjMDdjMGQ1NzU5XkEyXkFqcGdeQXVyMjY1OTQ0MDA@._V1_FMjpg_UX2160_.jpg", "Weird Barbie" },
                    { 28, 0, "https://m.media-amazon.com/images/M/MV5BMTA0MzA5MjU4ODFeQTJeQWpwZ15BbWU4MDYzOTI2NjMy._V1_FMjpg_UX1280_.jpg", "'K'" },
                    { 29, 0, "https://m.media-amazon.com/images/M/MV5BMjQ1MzQ2NTM3Ml5BMl5BanBnXkFtZTgwMzI5MjY2MzI@._V1_FMjpg_UX2048_.jpg", "Rick Deckard" },
                    { 30, 0, "https://m.media-amazon.com/images/M/MV5BZjE4MzcyMzMtZDM0ZS00ZWQ4LTg2N2MtMGEwZDE1OTBkNTYxXkEyXkFqcGdeQXVyNzg2ODI2OTU@._V1_FMjpg_UX2160_.jpg", "Sapper Morton" }
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
                    { 11, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") },
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
                name: "IX_Photos_MovieId",
                table: "Photos",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Movies_MovieId",
                table: "Photos",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Movies_MovieId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_MovieId",
                table: "Photos");

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 1, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 2, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 3, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 4, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 5, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 6, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 7, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 8, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 9, new Guid("075af806-fb6f-476d-804f-baecbd15bdd3") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 10, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 10, new Guid("506f4021-595b-4637-bba0-e2b88377549e") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 11, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 12, new Guid("13b84726-1968-4206-9f4b-856a4ba9998a") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 13, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 14, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 15, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 16, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 17, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 18, new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 20, new Guid("506f4021-595b-4637-bba0-e2b88377549e") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 21, new Guid("506f4021-595b-4637-bba0-e2b88377549e") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 22, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 23, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 24, new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 25, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 26, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 27, new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 28, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 29, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") });

            migrationBuilder.DeleteData(
                table: "MovieMovieCharacters",
                keyColumns: new[] { "MovieCharacterId", "MovieId" },
                keyValues: new object[] { 30, new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4") });

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MovieCharacters",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Photos");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MovieCharacters",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.CreateTable(
                name: "MoviePhotos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviePhotos", x => new { x.PhotoId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_MoviePhotos_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviePhotos_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MoviePhotos_MovieId",
                table: "MoviePhotos",
                column: "MovieId");
        }
    }
}
