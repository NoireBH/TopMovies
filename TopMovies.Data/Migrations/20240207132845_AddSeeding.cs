using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class AddSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "UserReviews",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "YearBorn" },
                values: new object[,]
                {
                    { 1, "With an authoritative voice and calm demeanor, this ever popular American actor has grown into one of the most respected figures in modern US cinema. Morgan was born on June 1, 1937 in Memphis, Tennessee, to Mayme Edna (Revere), a teacher, and Morgan Porterfield Freeman, a barber. The young Freeman attended Los Angeles City College before serving several years in the US Air Force as a mechanic between 1955 and 1959. His first dramatic arts exposure was on the stage including appearing in an all-African American production of the exuberant musical Hello, Dolly!.", "https://image.tmdb.org/t/p/w500/jPsLqiYGSofU4s6BjrxnefMfabb.jpg", "Morgan Freeman", new DateTime(1997, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Alfredo James \"Al\" 'Pacino established himself as a film actor during one of cinema's most vibrant decades, the 1970s, and has become an enduring and iconic figure in the world of American movies.He was born April 25, 1940 in Manhattan, New York City, to Italian-American parents, Rose (nee Gerardi) and Sal Pacino. They divorced when he was young. His mother moved them into his grandparents' home in the South Bronx. Pacino found himself often repeating the plots and voices of characters he had seen in the movies. Bored and unmotivated in school, he found a haven in school plays, and his interest soon blossomed into a full-time career. Starting onstage, he went through a period of depression and poverty, sometimes having to borrow bus fare to succeed to auditions. He made it into the prestigious Actors Studio in 1966, studying under Lee Strasberg, creator of the Method Approach that would become the trademark of many 1970s-era actors.", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Al_Pacino_2016_%2830401544240%29.jpg/640px-Al_Pacino_2016_%2830401544240%29.jpg", "Al Pacino", new DateTime(1940, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Christian Charles Philip Bale was born in Pembrokeshire, Wales, UK on January 30, 1974, to English parents Jennifer \"Jenny\" (James) and David Bale. His mother was a circus performer and his father, who was born in South Africa, was a commercial pilot. The family lived in different countries throughout Bale's childhood, including England, Portugal, and the United States. Bale acknowledges the constant change was one of the influences on his career choice.\r\n\r\nHis first acting job was a cereal commercial in 1983; amazingly, the next year, he debuted on the West End stage in \"The Nerd\". A role in the 1986 NBC mini-series Anastasia: The Mystery of Anna (1986) caught Steven Spielberg's eye, leading to Bale's well-documented role in Empire of the Sun (1987). For the range of emotions he displayed as the star of the war epic, he earned a special award by the National Board of Review for Best Performance by a Juvenile Actor.", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Christian_Bale_2009.jpg/800px-Christian_Bale_2009.jpg", "Christian Bale", new DateTime(1974, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "When hunky, twenty-year-old heart-throb Heath Ledger first came to the attention of the public in 1999, it was all too easy to tag him as a \"pretty boy\" and an actor of little depth. He spent several years trying desperately to sway this image, but this was a double-edged sword. His work comprised nineteen films, including 10 Things I Hate About You (1999), The Patriot (2000), A Knight's Tale (2001), Monster's Ball (2001), Ned Kelly (2003), The Brothers Grimm (2005), Lords of Dogtown (2005), Brokeback Mountain (2005), Casanova (2005), Candy (2006), I'm Not There (2007), The Dark Knight (2008) and The Imaginarium of Doctor Parnassus (2009). He also produced and directed music videos and aspired to be a film director.", "https://upload.wikimedia.org/wikipedia/commons/e/ea/Heath_Ledger_%282%29.jpg", "Heath Ledger", new DateTime(1979, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Samuel L. Jackson is an American producer and highly prolific actor, having appeared in over 100 films, including Die Hard: With a Vengeance (1995), Unbreakable (2000), Shaft (2000), The 51st State (2001), Black Snake Moan (2006), Snakes on a Plane (2006), and the Star Wars prequel trilogy (1999-2005), as well as the Marvel Cinematic Universe.\r\n\r\nSamuel Leroy Jackson was born in Washington, D.C., to Elizabeth (Montgomery) and Roy Henry Jackson. He was raised by his mother, a factory worker, and his grandparents. At Morehouse College, Jackson was active in the black student movement. In the seventies, he joined the Negro Ensemble Company (together with Morgan Freeman). In the eighties, he became well-known after three movies made by Spike Lee: Do the Right Thing (1989), Mo' Better Blues (1990) and Jungle Fever (1991). He achieved prominence and critical acclaim in the early 1990s with films such as Patriot Games (1992), Amos & Andrew (1993), True Romance (1993), Jurassic Park (1993), and his collaborations with director Quentin Tarantino, including Pulp Fiction (1994), Jackie Brown (1997), and later Django Unchained (2012). Going from supporting player to leading man, his performance in Pulp Fiction (1994) gave him an Oscar nomination for his character Jules Winnfield, and he received a Silver Berlin Bear for his part as Ordell Robbi in Jackie Brown (1997). Jackson usually played bad guys and drug addicts before becoming an action hero, co-starring with Bruce Willis in Die Hard: With a Vengeance (1995) and Geena Davis in The Long Kiss Goodnight (1996).", "https://m.media-amazon.com/images/M/MV5BMTQ1NTQwMTYxNl5BMl5BanBnXkFtZTYwMjA1MzY1._V1_.jpg", "Samuel L. Jackson", new DateTime(1948, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Animation" },
                    { 3, "Comedy" },
                    { 4, "Crime" },
                    { 5, "Drama" },
                    { 6, "Fantasy" },
                    { 7, "Sci-Fi" },
                    { 8, "Horror" },
                    { 9, "Romance" },
                    { 10, "History" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "Name", "Rating", "ReleaseDate" },
                values: new object[,]
                {
                    { new Guid("075af806-fb6f-476d-804f-baecbd15bdd3"), "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.\r\n\r\n", "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_FMjpg_UY2048_.jpg", false, "The Dark Knight", 0.0, 2008 },
                    { new Guid("13b84726-1968-4206-9f4b-856a4ba9998a"), "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.", "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1200_.jpg", false, "The Shawshank Redemption", 0.0, 1994 },
                    { new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da"), "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.\r\n\r\n", "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UX1055_.jpg", false, "Pulp Fiction", 0.0, 1994 },
                    { new Guid("2ca61990-fe17-483c-863d-442ee4c0acad"), "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.", "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1200_.jpg", false, "The Shawshank Redemption", 0.0, 1994 },
                    { new Guid("30da4459-9475-404d-92fb-9124cff7cfa6"), "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UY1982_.jpg", false, "The Godfather", 0.0, 1972 }
                });

            migrationBuilder.InsertData(
                table: "UserReviews",
                columns: new[] { "Id", "ApplicationUserId", "Comment", "MovieId", "Rating" },
                values: new object[,]
                {
                    { new Guid("176697c8-9480-447a-9e86-07b70b0a6585"), new Guid("735b0ad2-82a1-4394-a521-2b1dc921c737"), "A classic! My only complaint is that the pacing was too slow for my taste.If you have ADHD like me you're gonna have a hard time watching this movie, but i still think it's worth watching!", new Guid("30da4459-9475-404d-92fb-9124cff7cfa6"), 9 },
                    { new Guid("8efd4094-5824-434c-9019-eafb5cce9510"), new Guid("735b0ad2-82a1-4394-a521-2b1dc921c737"), "Peak fiction, they don't make dark batman movies like this anymore...", new Guid("075af806-fb6f-476d-804f-baecbd15bdd3"), 10 },
                    { new Guid("96475262-852c-442f-b88c-8642835ecb30"), new Guid("79228dc5-f961-4645-9fd7-e3bc820875e0"), "Not that great. Didn't remain consistent with Batman Begins and was extremely predictable. The plot and action labors along and never reaches a satisfying conclusion. The best thing about this film is the score.\r\n", new Guid("075af806-fb6f-476d-804f-baecbd15bdd3"), 4 },
                    { new Guid("ecd7d309-aa53-44bb-b876-27a6bf213dc5"), new Guid("735b0ad2-82a1-4394-a521-2b1dc921c737"), "One of the best movies I've ever seen!", new Guid("2ca61990-fe17-483c-863d-442ee4c0acad"), 10 },
                    { new Guid("fbd5e0af-4c33-411b-a0b3-88d7863f9d6e"), new Guid("79228dc5-f961-4645-9fd7-e3bc820875e0"), "While good it's extremely overrated", new Guid("30da4459-9475-404d-92fb-9124cff7cfa6"), 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("13b84726-1968-4206-9f4b-856a4ba9998a"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da"));

            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: new Guid("176697c8-9480-447a-9e86-07b70b0a6585"));

            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: new Guid("8efd4094-5824-434c-9019-eafb5cce9510"));

            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: new Guid("96475262-852c-442f-b88c-8642835ecb30"));

            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: new Guid("ecd7d309-aa53-44bb-b876-27a6bf213dc5"));

            migrationBuilder.DeleteData(
                table: "UserReviews",
                keyColumn: "Id",
                keyValue: new Guid("fbd5e0af-4c33-411b-a0b3-88d7863f9d6e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("075af806-fb6f-476d-804f-baecbd15bdd3"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("2ca61990-fe17-483c-863d-442ee4c0acad"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("30da4459-9475-404d-92fb-9124cff7cfa6"));

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                table: "UserReviews",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);
        }
    }
}
