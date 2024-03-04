using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class AddedActorMovieSeederAndFixedActorError : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "DateOfBirth", "Description", "ImageUrl", "Name" },
                values: new object[] { 1, new DateTime(1997, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "With an authoritative voice and calm demeanor, this ever popular American actor has grown into one of the most respected figures in modern US cinema. Morgan was born on June 1, 1937 in Memphis, Tennessee, to Mayme Edna (Revere), a teacher, and Morgan Porterfield Freeman, a barber. The young Freeman attended Los Angeles City College before serving several years in the US Air Force as a mechanic between 1955 and 1959. His first dramatic arts exposure was on the stage including appearing in an all-African American production of the exuberant musical Hello, Dolly!.", "https://image.tmdb.org/t/p/w500/jPsLqiYGSofU4s6BjrxnefMfabb.jpg", "Morgan Freeman" });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "DateOfBirth", "Description", "ImageUrl", "Name" },
                values: new object[] { 28, new DateTime(1948, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samuel L. Jackson is an American producer and highly prolific actor, having appeared in over 100 films, including Die Hard: With a Vengeance (1995), Unbreakable (2000), Shaft (2000), The 51st State (2001), Black Snake Moan (2006), Snakes on a Plane (2006), and the Star Wars prequel trilogy (1999-2005), as well as the Marvel Cinematic Universe.\r\n\r\nSamuel Leroy Jackson was born in Washington, D.C., to Elizabeth (Montgomery) and Roy Henry Jackson. He was raised by his mother, a factory worker, and his grandparents. At Morehouse College, Jackson was active in the black student movement. In the seventies, he joined the Negro Ensemble Company (together with Morgan Freeman). In the eighties, he became well-known after three movies made by Spike Lee: Do the Right Thing (1989), Mo' Better Blues (1990) and Jungle Fever (1991). He achieved prominence and critical acclaim in the early 1990s with films such as Patriot Games (1992), Amos & Andrew (1993), True Romance (1993), Jurassic Park (1993), and his collaborations with director Quentin Tarantino, including Pulp Fiction (1994), Jackie Brown (1997), and later Django Unchained (2012). Going from supporting player to leading man, his performance in Pulp Fiction (1994) gave him an Oscar nomination for his character Jules Winnfield, and he received a Silver Berlin Bear for his part as Ordell Robbi in Jackie Brown (1997). Jackson usually played bad guys and drug addicts before becoming an action hero, co-starring with Bruce Willis in Die Hard: With a Vengeance (1995) and Geena Davis in The Long Kiss Goodnight (1996).\r\n\r\nWith Jackson's permission, his likeness was used for the Ultimate version of the Marvel Comics character, Nick Fury. He later did a cameo as the character in a post-credits scene from Iron Man (2008), and went on to sign a nine-film commitment to reprise this role in future films, including major roles in Iron Man 2 (2010), Avengers Assemble (2012), Captain America: The Winter Soldier (2014) and Avengers: Age of Ultron (2015) and minor roles in Thor (2011) and Captain America: The First Avenger (2011). He has also portrayed the character in the second and final episodes of the first season of the TV show, Marvel's Agents of S.H.I.E.L.D. (2013). He has provided his voice to several animated films, television series and video games, including the roles of Lucius Best / Frozone in Pixar's film The Incredibles (2004), Mace Windu in Star Wars: The Clone Wars (2008), Afro Samurai in the anime television series Afro Samurai (2007), and Frank Tenpenny in the video game Grand Theft Auto: San Andreas (2004).", "https://m.media-amazon.com/images/M/MV5BMTQ1NTQwMTYxNl5BMl5BanBnXkFtZTYwMjA1MzY1._V1_FMjpg_UX1000_.jpg", "Samuel Jackson" });

            migrationBuilder.InsertData(
                table: "ActorMovies",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[] { 1, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorMovies",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, new Guid("2ca61990-fe17-483c-863d-442ee4c0acad") });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
