using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class AddedActorMovieSeeder : Migration
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
                    { 1, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") },
                    { 2, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") },
                    { 3, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") },
                    { 4, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") },
                    { 5, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") },
                    { 6, new Guid("30da4459-9475-404d-92fb-9124cff7cfa6") },
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
                values: new object[] { 28, new DateTime(1948, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel L. Jackson is an American producer and highly prolific actor, having appeared in over 100 films, including Die Hard: With a Vengeance (1995), Unbreakable (2000), Shaft (2000), The 51st State (2001), Black Snake Moan (2006), Snakes on a Plane (2006), and the Star Wars prequel trilogy (1999-2005), as well as the Marvel Cinematic Universe.\r\n\r\nSamuel Leroy Jackson was born in Washington, D.C., to Elizabeth (Montgomery) and Roy Henry Jackson. He was raised by his mother, a factory worker, and his grandparents. At Morehouse College, Jackson was active in the black student movement. In the seventies, he joined the Negro Ensemble Company (together with Morgan Freeman). In the eighties, he became well-known after three movies made by Spike Lee: Do the Right Thing (1989), Mo' Better Blues (1990) and Jungle Fever (1991). He achieved prominence and critical acclaim in the early 1990s with films such as Patriot Games (1992), Amos & Andrew (1993), True Romance (1993), Jurassic Park (1993), and his collaborations with director Quentin Tarantino, including Pulp Fiction (1994), Jackie Brown (1997), and later Django Unchained (2012). Going from supporting player to leading man, his performance in Pulp Fiction (1994) gave him an Oscar nomination for his character Jules Winnfield, and he received a Silver Berlin Bear for his part as Ordell Robbi in Jackie Brown (1997). Jackson usually played bad guys and drug addicts before becoming an action hero, co-starring with Bruce Willis in Die Hard: With a Vengeance (1995) and Geena Davis in The Long Kiss Goodnight (1996).\r\n\r\nWith Jackson's permission, his likeness was used for the Ultimate version of the Marvel Comics character, Nick Fury. He later did a cameo as the character in a post-credits scene from Iron Man (2008), and went on to sign a nine-film commitment to reprise this role in future films, including major roles in Iron Man 2 (2010), Avengers Assemble (2012), Captain America: The Winter Soldier (2014) and Avengers: Age of Ultron (2015) and minor roles in Thor (2011) and Captain America: The First Avenger (2011). He has also portrayed the character in the second and final episodes of the first season of the TV show, Marvel's Agents of S.H.I.E.L.D. (2013). He has provided his voice to several animated films, television series and video games, including the roles of Lucius Best / Frozone in Pixar's film The Incredibles (2004), Mace Windu in Star Wars: The Clone Wars (2008), Afro Samurai in the anime television series Afro Samurai (2007), and Frank Tenpenny in the video game Grand Theft Auto: San Andreas (2004).", "https://m.media-amazon.com/images/M/MV5BMTQ1NTQwMTYxNl5BMl5BanBnXkFtZTYwMjA1MzY1._V1_FMjpg_UX1000_.jpg", "Samuel Jackson" });

            migrationBuilder.InsertData(
                table: "ActorMovies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 28, new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da") });
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
                keyValues: new object[] { 1, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") });

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
                keyValue: 28);
        }
    }
}
