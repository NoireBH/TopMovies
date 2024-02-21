﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopMovies.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 10000, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieCharacters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCharacters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActorMovieCharacters",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    MovieCharacterId = table.Column<int>(type: "int", nullable: false)
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
                name: "ActorMovies",
                columns: table => new
                {
                    ActorId = table.Column<int>(type: "int", nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovies", x => new { x.MovieId, x.ActorId });
                    table.ForeignKey(
                        name: "FK_ActorMovies_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovies_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenres",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenres", x => new { x.GenreId, x.MovieId });
                    table.ForeignKey(
                        name: "FK_MovieGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieMovieCharacters",
                columns: table => new
                {
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieCharacterId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "UserReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    MovieId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserReviews_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserReviews_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "DateOfBirth", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 2, new DateTime(1958, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Born in West Covina, California, but raised in New York City, Tim Robbins is the son of former The Highwaymen singer Gil Robbins and actress Mary Robbins (née Bledsoe). Robbins studied drama at UCLA, where he graduated with honors in 1981. That same year, he formed the Actors' Gang theater group, an experimental ensemble that expressed radical political observations through the European avant-garde form of theater. He started film work in television movies in 1983, but hit the big time in 1988 with his portrayal of dimwitted fastball pitcher \"Nuke\" Laloosh in Bull Durham (1988). Tall with baby-faced looks, he has the ability to play naive and obtuse (Cadillac Man (1990) and The Hudsucker Proxy (1994)) or slick and shrewd (The Player (1992) and Bob Roberts (1992)).", "https://m.media-amazon.com/images/M/MV5BMTI1OTYxNzAxOF5BMl5BanBnXkFtZTYwNTE5ODI4._V1_FMjpg_UX1000_.jpg", "Tim Robbins" },
                    { 3, new DateTime(1959, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "A tall, wavy-haired US actor with a deep, resonant voice, Clancy Brown has proven himself a versatile performer with first-class contributions to theatre, feature films, television series and even animation.\r\n\r\nClarence J. Brown III was born in 1959 in Urbana, Ohio, to Joyce Helen (Eldridge), a concert pianist, conductor, and composer, and Clarence J. \"Bud\" Brown, Jr., who helped manage the Brown Publishing Company, the family-owned newspaper started by Clancy's grandfather, Clarence J. Brown. Clancy's father and grandfather were also Republican congressmen from the same Ohio district, and Clancy spent much of his youth in close proximity to Washington, D.C. He plied his dramatic talents in the Chicago theatre scene before moving onto feature film with a sinister debut performance bullying Sean Penn inside a youth reformatory in Bad Boys (1983). He portrayed Viktor the Monster in the unusual spin on the classic Frankenstein story in The Bride (1985), before scoring one of his best roles to date as the evil Kurgan hunting fellow immortals Christopher Lambert and Sean Connery across four centuries of time in Highlander (1986).\r\n\r\nBrown played a corrupt American soldier in the Walter Hill-directed hyper-violent action film Extreme Prejudice (1987), another deranged killer in Deadly Pursuit (1988) and a brutal prison guard, who eventually somewhat \"befriends\" wrongfully convicted banker Tim Robbins, in the moving The Shawshank Redemption (1994). His superb vocal talents were in demand, and he contributed voices to animated series, including Mortal Kombat: Defenders of the Realm (1995), Street Sharks (1994), Gargoyles (1994) and Superman: The Animated Series (1996). Brown then landed two more plum roles, one as a \"tough-as-nails\" drill sergeant in the science fiction thriller Starship Troopers (1997), and the other alongside Robin Williams in the Disney comedy Flubber (1997).\r\n\r\nThe video gaming industry took notice of Clancy's vocal abilities, too, and he has contributed voices to several top selling video games, including Crash Bandicoot: The Wrath of Cortex (2001), Lands of Lore III (1999), Star Wars: Bounty Hunter (2002) and Crash Nitro Kart (2003). His voice is also the character of cranky crustacean Mr. Eugene H. Krabs in the highly successful SpongeBob SquarePants (1999) animated series and films, and he contributed voices to The Batman (2004), Jackie Chan Adventures (2000) and Justice League (2001) animated series. A popular and friendly personality, Clancy Brown continues to remain busy both through his vocal and acting talents in Hollywood.", "https://m.media-amazon.com/images/M/MV5BMTUxODY3NjAzMF5BMl5BanBnXkFtZTcwMTQ5MjYwNg@@._V1_FMjpg_UX1000_.jpg", "Clancy Brown" },
                    { 4, new DateTime(1940, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alfredo James \"Al\" 'Pacino established himself as a film actor during one of cinema's most vibrant decades, the 1970s, and has become an enduring and iconic figure in the world of American movies.He was born April 25, 1940 in Manhattan, New York City, to Italian-American parents, Rose (nee Gerardi) and Sal Pacino. They divorced when he was young. His mother moved them into his grandparents' home in the South Bronx. Pacino found himself often repeating the plots and voices of characters he had seen in the movies. Bored and unmotivated in school, he found a haven in school plays, and his interest soon blossomed into a full-time career. Starting onstage, he went through a period of depression and poverty, sometimes having to borrow bus fare to succeed to auditions. He made it into the prestigious Actors Studio in 1966, studying under Lee Strasberg, creator of the Method Approach that would become the trademark of many 1970s-era actors.", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Al_Pacino_2016_%2830401544240%29.jpg/640px-Al_Pacino_2016_%2830401544240%29.jpg", "Al Pacino" },
                    { 5, new DateTime(1946, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diane Keaton was born Diane Hall in Los Angeles, California, to Dorothy Deanne (Keaton), an amateur photographer, and John Newton Ignatius \"Jack\" Hall, a civil engineer and real estate broker. She studied Drama at Santa Ana College, before dropping out in favor of the Neighborhood Playhouse in New York. After appearing in summer stock for several months, she got her first major stage role in the Broadway rock musical \"Hair\". As understudy to the lead, she gained attention by not removing any of her clothing. In 1968, Woody Allen cast her in his Broadway play \"Play It Again, Sam,\" which had a successful run. It was during this time that she became involved with Allen and appeared in a number of his films. The first one was Play It Again, Sam (1972), the screen adaptation of the stage play. That same year Francis Ford Coppola cast her as Kay in the Oscar-winning The Godfather (1972), and she was on her way to stardom. She reprized that role in the film's first sequel, The Godfather Part II (1974). She then appeared with Allen again in Sleeper (1973) and Love and Death (1975).\r\n\r\nIn 1977, she broke away from her comedy image to appear in the chilling Mr. Goodbar (1977), which won her a Golden Globe nomination. It was the same year that she appeared in what many regard as her best performance, in the title role of Annie Hall (1977), which Allen wrote specifically for her (her real last name is Hall, and her nickname is Annie), and what an impact she made. She won the Oscar and the British Award for Best Actress, and Allen won the Directors Award from the DGA. She started a fashion trend with her unisex clothes and was the poster girl for a lot of young males. Her mannerisms and awkward speech became almost a national craze. The question being asked, though, was, \"Is she just a lightweight playing herself, or is there more depth to her personality?\" For whatever reason, she appeared in but one film a year for the next two years and those films were by Allen. When they broke up she was next involved with Warren Beatty and appeared in his film Reds (1981), as the bohemian female journalist Louise Bryant. For her performance, she received nominations for the Academy Award and the Golden Globe. For the rest of the 1980s she appeared infrequently in films but won nominations in three of them. Attempting to break the typecasting she had fallen into, she took on the role of a confused, somewhat naive woman who becomes involved with Middle Eastern terrorists in The Little Drummer Girl (1984). To offset her lack of movie work, Diane began directing. She directed the documentary Heaven (1987), as well as some music videos. For television she directed an episode of the popular, but strange, Twin Peaks (1990).", "https://m.media-amazon.com/images/M/MV5BMTY5NDI5OTEyOF5BMl5BanBnXkFtZTgwMzU4NDI1NzM@._V1_FMjpg_UX1000_.jpg", "Diane Keaton" },
                    { 7, new DateTime(1974, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christian Charles Philip Bale was born in Pembrokeshire, Wales, UK on January 30, 1974, to English parents Jennifer \"Jenny\" (James) and David Bale. His mother was a circus performer and his father, who was born in South Africa, was a commercial pilot. The family lived in different countries throughout Bale's childhood, including England, Portugal, and the United States. Bale acknowledges the constant change was one of the influences on his career choice.\r\n\r\nHis first acting job was a cereal commercial in 1983; amazingly, the next year, he debuted on the West End stage in \"The Nerd\". A role in the 1986 NBC mini-series Anastasia: The Mystery of Anna (1986) caught Steven Spielberg's eye, leading to Bale's well-documented role in Empire of the Sun (1987). For the range of emotions he displayed as the star of the war epic, he earned a special award by the National Board of Review for Best Performance by a Juvenile Actor.", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Christian_Bale_2009.jpg/800px-Christian_Bale_2009.jpg", "Christian Bale" },
                    { 8, new DateTime(1979, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "When hunky, twenty-year-old heart-throb Heath Ledger first came to the attention of the public in 1999, it was all too easy to tag him as a \"pretty boy\" and an actor of little depth. He spent several years trying desperately to sway this image, but this was a double-edged sword. His work comprised nineteen films, including 10 Things I Hate About You (1999), The Patriot (2000), A Knight's Tale (2001), Monster's Ball (2001), Ned Kelly (2003), The Brothers Grimm (2005), Lords of Dogtown (2005), Brokeback Mountain (2005), Casanova (2005), Candy (2006), I'm Not There (2007), The Dark Knight (2008) and The Imaginarium of Doctor Parnassus (2009). He also produced and directed music videos and aspired to be a film director.", "https://upload.wikimedia.org/wikipedia/commons/e/ea/Heath_Ledger_%282%29.jpg", "Heath Ledger" },
                    { 9, new DateTime(1976, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Striking Irish actor Cillian Murphy was born in Douglas, the oldest child of Brendan Murphy, who works for the Irish Department of Education, and a mother who is a teacher of French. He has three younger siblings. Murphy was educated at Presentation Brothers College, Cork. He went on to study law at University College Cork, but dropped out after about a year. During this time, Murphy also pursued an interest in music, playing guitar in various bands. Upon leaving University, Murphy joined the Corcadorca Theater Company in Cork, and played the lead role in \"Disco Pigs\", amongst other plays.\r\n\r\nVarious film roles followed, including a film adaptation of Disco Pigs (2001). However, his big film break came when he was cast in Danny Boyle's 28 Days Later (2002), which became a surprise international hit. This performance earned him nominations for Best Newcomer at the Empire Awards and Breakthrough Male Performance at the MTV Movie Awards.\r\n\r\nMurphy went on to supporting roles in high-profile films such as Cold Mountain (2003) and Girl with a Pearl Earring (2003), and then was cast in two villain roles: Dr. Jonathan Crane, aka The Scarecrow, in Batman Begins (2005) and Jackson Rippner in Red Eye (2005). Although slight in nature for a villain, Murphy's piercing blue eyes helped to create creepy performances and critics began to take notice. Manhola Dargis of the New York Times cited Murphy as a \"picture-perfect villain\", while David Denby of The New Yorker noted he was both \"seductive\" and \"sinister\".\r\n\r\nLater that year, Murphy starred as Patrick \"Kitten\" Braden, an Irish transgender woman in search of her mother in Neil Jordan's Breakfast on Pluto (2005), a film adaptation of the Pat McCabe novel. Although the film was not a box office success, Murphy was nominated for a Golden Globe for Best Actor in a Comedy or Musical and he won Best Actor for the Irish Film and Television Academy Awards.\r\n\r\nThe following year, Murphy starred in Ken Loach's The Wind that Shakes the Barley (2006). The film was the most successful independent Irish film and won the Palm D'Or at the 2006 Cannes Film Festival. Murphy continued to take roles in a number of independent films, and also reprised his role as the Scarecrow in Christopher Nolan's The Dark Knight (2008). Nolan is known for working with actors in multiple films, and cast Murphy in Inception (2010) as Robert Fischer, the young heir of the multi-billion dollar empire, who was the target of DiCaprio's dream team. His most well-known work is starring as Thomas Shelby in the British TV show Peaky Blinders beginning in 2013.\r\n\r\nMurphy continues to appear in high-profile films such as In Time (2011), Red Lights (2012), and The Dark Knight Rises (2012), the final film in Nolan's Batman trilogy.\r\n\r\nMurphy is married to Yvonne McGuinness, an artist. The couple have two sons, Malachy and Aran.", "https://m.media-amazon.com/images/M/MV5BMDUxY2M1NTQtNzcwNC00ZDljLTk4YjctYzJjZGNiYTc0YTE1XkEyXkFqcGdeQXVyMTY5MDA5MDc3._V1_.jpg", "Cillian Murphy" },
                    { 10, new DateTime(1977, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leigh Whannell grew up in Melbourne, Australia, where, at the age of four, he developed an obsession with telling stories. Whether it be through acting, writing or filmmaking, his primary love was getting a reaction from an audience. In 1995, at the age of 18, he was accepted into the Royal Melbourne Institute of Technology's prestigious Media Arts course, where he met fellow filmmaker James Wan. In his second year of college, he landed the role of \"film guy\" on a Saturday morning TV show aimed at teens called Recovery (1996). Filmed totally live in the studio and hosted by actual teenagers, the ground-breaking show was hugely popular down under and was the first to bring \"alternative culture\" to Australia's TV screens, featuring live performances from bands like Sonic Youth, Weezer, Public Enemy, Ben Harper, Pulp and hundreds more. Hosting the film component of the show, Leigh was lucky enough to interview people like Tim Burton, Peter Jackson, Russell Crowe, George Clooney, and eventually went on the host the show in 1999. After graduating from college, Leigh found himself working more and more as a \"host\" or \"presenter\" on Australian TV - all the while hatching a plan with James Wan to finally fulfill his dream of making a film. Small acting roles cropped up from time to time (including one in The Matrix Reloaded (2003), which Leigh has said was \"the most fun I've ever had in my life\") and, along with those, some frustrating near-misses (and not so near-misses: like his cringe-inducing audition for \"Lord Of The Rings\", in which he paid $90 to have \"hobbit ears\" grafted onto his head, turning up at the casting office dressed as a hobbit - needless to say he didn't get the role). However, it was missing out on a role in Alex Proyas Australian film Garage Days (2002) that finally broke the camel's back. He called Wan and told him that if they wanted to get a film made, they would have to pay for it themselves. Saw (2004) was born. After nine months of writing, Leigh had written the screenplay for what he thought would be a self-financed, \"Blair Witch\"-style feature, with him starring and James directing. The script gained so much attention that soon enough, they were shopping it around Hollywood....and the rest is history.", "https://m.media-amazon.com/images/M/MV5BMTkyMzA3OTI0Ml5BMl5BanBnXkFtZTcwNDUzMTEzMQ@@._V1_FMjpg_UX1000_.jpg", "Leigh Whannell" },
                    { 11, new DateTime(1962, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cary Elwes was born in Westminster, London, England, the third son of interior designer/shipping heiress Tessa Georgina Kennedy and the late portrait painter Bede Evelyn Dominick Elwes. He is the brother of producer/agent Cassian Elwes and artist Damian Elwes. He was raised in London and attended Harrow. After graduating from Harrow, he moved to the US and studied drama at Sarah Lawrence College. He left school after two years to begin his film career. Cary is well respected by colleagues and fans alike and considered by many to be one of the finest actors working today. He is interested in history and says, \"It's deliberate that a lot of my films have been period pieces\". He is politically active for causes he believes in, such as protecting the environment and helping Native American people.\r\n\r\nElwes is married to Lisa Marie Kurbikoff, a stills photographer. He comes from a long-established recusant English family on his father's side. Several prominent Catholic clerics are among his relatives, including Fr. Luke Cary-Elwes, Dom Columba Cary-Elwes, and Dom Cuthbert Cary-Elwes. His grandfather was society painter and war artist Simon Elwes. Cary (the surname \"Cary-Elwes\" was shortened to \"Elwes\" in some branches of the family) was an altar boy at London's Brompton Oratory, although he did not attend a Catholic high school. From his maternal grandmother, Daska Marija Ivanovic-Banac, who was born in Osijek in the Austra-Hungarian Empire (now in Croatia), he has Croatian Jewish and Serbian ancestry. Cary's other lineage is English, Irish, and Scottish.", "https://m.media-amazon.com/images/M/MV5BOTUxNzY3NTAxNF5BMl5BanBnXkFtZTgwNjU4MDU0NzE@._V1_FMjpg_UX1000_.jpg", "Cary Elwes" },
                    { 12, new DateTime(1942, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tobin Bell is an American actor with a career in film, television and theater spanning three decades. He was born in Queens, New York and raised in Weymouth, Mass. His mother is the British actress Eileen Bell. He is perhaps best known for his role as the iconic villain \"Jigsaw\" in the Saw film series...for which he received MTV Award nominations in 2007 & 2009. He's a graduate of Boston University and has a Masters Degree in Education from Montclair State University. He studied acting with Sanford Meisner at the Neighborhood Playhouse and Lee Strasberg at the Actors Studio in New York. He is a lifetime member of The Actors Studio and a member of The Academy of Motion Picture Arts and Sciences.", "https://m.media-amazon.com/images/M/MV5BNjM5OTE1MjA3Nl5BMl5BanBnXkFtZTgwOTAxNjk4MDE@._V1_FMjpg_UX1000_.jpg", "Tobin Bell" },
                    { 13, new DateTime(1954, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "John Joseph Travolta was born in Englewood, New Jersey, one of six children of Helen Travolta (née Helen Cecilia Burke) and Salvatore/Samuel J. Travolta. His father was of Italian descent and his mother was of Irish ancestry. His father owned a tire repair shop called Travolta Tires in Hillsdale, NJ. Travolta started acting appearing in a local production of \"Who'll Save the Plowboy?\". His mother, herself an actress and dancer, enrolled him in a drama school in New York, where he studied voice, dancing and acting. He decided to combine all three of these skills and become a musical comedy performer. At 16 he landed his first professional job in a summer stock production of the musical \"Bye Bye Birdie\". He quit school at 16 and moved to New York, and worked regularly in summer stock and on television commercials. When work became scarce in New York, he went to Hollywood and appeared in minor roles in several series. A role in the national touring company of the hit 1950s musical \"Grease\" brought him back to New York. An opening in the New York production of \"Grease\" gave him his first Broadway role at age 18. After \"Grease\", he became a member of the company of the Broadway show \"Over Here\", which starred The Andrews Sisters. After ten months in \"Over Here\", he decided to try Hollywood once again. Once back in Hollywood, he had little trouble getting roles in numerous television shows. He was seen on The Rookies (1972), Emergency! (1972) and Calling Dr. Gannon (1969) and also made a movie, The Devil's Rain (1975), which was shot in New Mexico. The day he returned to Hollywood from New Mexico, he was called to an audition for a new situation comedy series ABC was planning to produce called Welcome Back, Kotter (1975). He got the part of Vinnie Barbarino and the series went on the air during the 1975 fall season.\r\n\r\nHe starred in a number of monumental films, earning his first Oscar and Golden Globe nominations for his role in the blockbuster Saturday Night Fever (1977), which launched the disco phenomenon in the 1970s. He went on to star in the big-screen version of the long-running musical Grease (1978) and the wildly successful Urban Cowboy (1980), which also influenced trends in popular culture. Additional film credits include the Brian De Palma thrillers Carrie (1976) and Blow Out (1981), as well as Amy Heckerling's hit comedy Look Who's Talking (1989) and Nora Ephron's comic hit Michael (1996). Travolta starred in Phenomenon (1996) and took an equally distinctive turn as an action star in John Woo's top-grossing Broken Arrow (1996). He also starred in the classic Face/Off (1997) opposite Nicolas Cage, and The General's Daughter (1999), co-starring Madeleine Stowe. In 2005, Travolta reprised the role of ultra cool Chili Palmer in the Get Shorty (1995) sequel Be Cool (2005). In addition, he starred opposite Scarlett Johansson in the critically-acclaimed independent feature film A Love Song for Bobby Long (2004), which was screened at the Venice Film Festival, where both Travolta and the films won rave reviews. In February 2011, John was honored by Europe's leading weekly program magazine HORZU, with the prestigious Golden Camera Award for \"Best Actor International\" in Berlin, Germany. Other recent feature film credits include box-office hit-comedy \"Wild Hogs\", the action-thriller Ladder 49 (2004), the movie version of the successful comic book The Punisher (2004), the drama Basic (2003), the psychological thriller Domestic Disturbance (2001), the hit action picture Swordfish (2001), the infamous sci-fi movie Battlefield Earth (2000), based upon the best-selling novel by L. Ron Hubbard, and Lonely Hearts (2006).\r\n\r\nTravolta has been honored twice with Academy Award nominations, the latest for his riveting portrayal of a philosophical hit-man in Quentin Tarantino's Pulp Fiction (1994). He also received BAFTA and Golden Globe nominations for this highly-acclaimed role and was named Best Actor by the Los Angeles Film Critics Association, among other distinguished awards. Travolta garnered further praise as a Mafioso-turned-movie producer in the comedy sensation Get Shorty (1995), winning the Golden Globe Award for Best Actor in a Motion Picture, Musical or Comedy. In 1998, Travolta was honored by the British Academy of Film and Television Arts with the Britanna Award: and in that same year he received the Lifetime Achievement Award at the Chicago Film Festival. Travolta also won the prestigious Alan J. Pakula Award from the US Broadcast Critics Association for his performance in A Civil Action (1998), based on the best-selling book and directed by Steven Zaillian. He was nominated again for a Golden Globe for his performance in Primary Colors (1998), directed by Mike Nichols and co-starring Emma Thompson and Billy Bob Thornton, and in 2008, he received his sixth Golden Globe nomination for his role as \"Edna Turnblad\" in the big-screen, box-office hit, Hairspray (2007). As a result of this performance, the Chicago Film Critics and the Santa Barbara Film Festival decided to recognize Travolta with a Lifetime Achievement Award for his role.\r\n\r\nIn addition, Travolta starred opposite Denzel Washington in Tony Scott's remake The Taking of Pelham 123 (2009), and he provided the voice of the lead character in Walt Disney Pictures' animated hit Bolt (2008), which was nominated for a 2009 Academy Award for Best Animated Feature Film and a Golden Globe for Best Animated Film, in addition to Best Song for John and Miley Cyrus' duet titled, \"I Thought I Lost You\".\r\n\r\nNext, Travolta starred in Walt Disney Pictures' Old Dogs (2009), along with Robin Williams, Kelly Preston and Ella Bleu Travolta, followed by the action thriller From Paris with Love (2010), starring opposite Jonathan Rhys Meyers. In 2012, John starred alongside Taylor Kitsch, Blake Lively, Aaron Taylor-Johnson, Benicio Del Toro, Salma Hayek, Emile Hirsch and Demián Bichir in Oliver Stone's, Savages (2012). The film was based on Don Winslow's best-selling crime novel that was named one of The New York Times' Top 10 Books of 2010. John was most recently seen in Killing Season (2013), co-starring Robert De Niro, and directed by Mark Steven Johnson. John recently completed production on the Boston-based film, The Forger (2014), alongside Academy Award winner Christopher Plummer and Critic's Choice nominee Tye Sheridan. John plays a second-generation petty thief who arranges to get out of prison to spend time with his ailing son (Sheridan) by taking on a job with his father (Plummer) to pay back the syndicate that arranged his release. John has received 2 prestigious aviation awards: in 2003, the American Institute of Aeronautics and Astronautics Foundation Award for Excellence for his efforts to promote commercial flying, and, in 2007, The Living Legends Ambassador of Aviation award.\r\n\r\nJohn holds 11 jet licenses: 747, 707, Gulfstream II, Lear 24, Hawker 1251A, Eclipse Jet, Vampire Jet, Canadair CL-141 Jet, Soko Jet, Citation ISP and Challenger. Travolta is the Qantas Airways Global Goodwill \"Ambassador-at-Large\" and piloted the original Qantas 707 during \"Spirit of Friendship\" global tour in July/August 2002. John is also a business aircraft brand ambassador for Learjet, Challenger and Global jets for the world's leading business aircraft manufacturer, Bombardier. John flew the 707 to New Orleans after the 2005 hurricane disaster bringing food and medical supplies, and in 2010, again flew the 707, this time to Haiti after the earthquake, carrying supplies, doctors and volunteers.\r\n\r\nJohn, along with his late wife, actress Kelly Preston (1962-2020), were very involved in their charity, The Jett Travolta Foundation, which raises money for children with educational needs.", "https://m.media-amazon.com/images/M/MV5BMTMyMjZlYzgtZWRjMC00OTRmLTllZTktMmM1ODVmNjljMTQyXkEyXkFqcGdeQXVyMTExNzQ3MzAw._V1_.jpg", "John Travolta" },
                    { 14, new DateTime(1970, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uma Karuna Thurman was born in Boston, Massachusetts, into a highly unorthodox and internationally-minded family. She is the daughter of Nena Thurman (née Birgitte Caroline von Schlebrügge), a fashion model and socialite who now runs a mountain retreat, and of Robert Thurman (Robert Alexander Farrar Thurman), a professor and academic who is one of the nation's foremost Buddhist scholars. Uma's mother was born in Mexico City, Mexico, to a German father and a Swedish mother (who herself was of Swedish, Danish, and German descent). Uma's father, a New Yorker, has English, Scots-Irish, Scottish, and German ancestry. Uma grew up in Amherst, Massachusetts, where her father worked at Amherst College.\r\n\r\nShe and her siblings all have names deriving from Buddhist mythology; and Middle American behavior was little understood, much less pursued. And so it was that the young Thurman confronted childhood with an odd name and eccentric home life -- and nature seemingly conspired against her as well. She is six feet tall, and from an early age towered over everyone else in class. Her famously large feet would soon sprout to size 11 -- and even beyond that -- and although they would eventually be lovingly filmed by director Quentin Tarantino, as a child she generally wore the biggest shoes in class, which only provided another subject of ridicule. Even her long nose moved one of her mother's friends to helpfully suggest rhinoplasty -- to the ten-year-old Thurman. To make matters worse yet, the family constantly relocated, making the gangly, socially inept Thurman perpetually the new kid in class. The result was an exceptionally awkward, self-conscious, lonely and alienated childhood.\r\n\r\nUnsurprisingly, the young Thurman enjoyed making believe she was someone other than herself, and so thrived at acting in school plays -- her sole successful extracurricular activity. This interest, and her lanky frame, perfect for modeling, led the 15-year-old Thurman to New York City for high school and modeling work (including a layout in Glamour Magazine) as she sought acting roles. The roles soon came, starting with a few formulaic and forgettable Hollywood products, but immediately followed by Terry Gilliam's The Adventures of Baron Munchausen (1988) and Stephen Frears' Dangerous Liaisons (1988), both of which brought much attention to her unorthodox sensuality and performances that intriguingly combined innocence and worldliness. The weird, gangly girl became a sex symbol virtually overnight.\r\n\r\nThurman continued to be offered good roles in Hollywood pictures into the early '90s, the least commercially successful but probably best-known of which was her smoldering, astonishingly-adult performance as June, Henry Miller's wife, in Henry & June (1990), the first movie to actually receive the dreaded NC-17 rating in the USA. After a celebrated start, Thurman's career stalled in the early '90s with movies such as the mediocre Mad Dog and Glory (1993). Worse, her first starring role was in Even Cowgirls Get the Blues (1993), which had endured a tortured journey from cult-favorite book to big-budget movie, and was a critical and financial debacle. Fortunately, Uma bounced back with a brilliant performance as Mia Wallace, that most unorthodox of all gangster's molls, in Tarantino's lauded, hugely successful Pulp Fiction (1994), a role for which Thurman received an Academy Award nomination.\r\n\r\nSince then, Thurman has had periods of flirting with roles in arty independents such as A Month by the Lake (1995), and supporting roles in which she has lent some glamorous presence to a mixed batch of movies, such as Beautiful Girls (1996) and The Truth About Cats & Dogs (1996). Thurman returned to smaller films after playing the villainess Poison Ivy in the reviled Joel Schumacher effort Batman & Robin (1997) and Emma Peel in a remake of The Avengers (1998). She worked with Woody Allen and Sean Penn on Sweet and Lowdown (1999), and starred in Richard Linklater's drama Tape (2001) opposite Hawke. Thurman also won a Golden Globe award for her turn in the made-for-television film Hysterical Blindness (2002), directed by Mira Nair.\r\n\r\nA return to the mainstream spotlight came when Thurman re-teamed with Quentin Tarantino for Kill Bill: Vol. 1 (2003), a revenge flick the two had dreamed up on the set of Pulp Fiction (1994). She also turned up in the John Woo cautioner Paycheck (2003) that same year. The renewed attention was not altogether welcome because Thurman was dealing with the break-up of her marriage with Hawke at about this time. Thurman handled the situation with grace, however, and took her surging popularity in stride. She garnered critical acclaim for her work in Kill Bill: Vol. 2 (2004) and was hailed as Tarantino's muse. Thurman reunited with Pulp Fiction (1994) dance partner John Travolta for the Get Shorty (1995) sequel Be Cool (2005) and played Ulla in The Producers (2005).\r\n\r\nThurman had been briefly married to Gary Oldman, from 1990 to 1992. In 1998, she married Ethan Hawke, her co-star in the offbeat futuristic thriller Gattaca (1997). The couple had two children, Levon and Maya. Hawke and Thurman filed for divorce in 2004.", "https://m.media-amazon.com/images/M/MV5BMjMxNzk1MTQyMl5BMl5BanBnXkFtZTgwMDIzMDEyMTE@._V1_FMjpg_UX1000_.jpg", "Uma Thurman" },
                    { 15, new DateTime(1192, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshua Ryan Hutcherson was born on October 12, 1992 in Union, Kentucky to Michelle Fightmaster, who worked for Delta Air Lines, and Chris Hutcherson, an EPA analyst. He has one younger brother, Connor Hutcherson. From the age of four, Josh knew that he wanted to be an actor. In order to pursue his goal, Josh and his family moved to Los Angeles when he was nine-years-old.\r\n\r\nIn 2002, Josh landed his first acting role in the TV film, House Blend (2002), with Amy Yasbeck, Dan Cortese and Sean Faris. The same year, Josh was cast in the pilot, Becoming Glen (2002), but Fox did not order it to series (though, several years later, it was reconfigured as the short-lived series, The Winner (2007), starring Rob Corddry, and co-written/produced by Seth MacFarlane). Toward the end of 2002, Josh appeared on an episode of ER (1994).\r\n\r\nJosh made his big-screen debut, in 2003, with a bit part in the Oscar-nominated American Splendor (2003). His career began its measured ascent in 2005 with a supporting slot as one of Will Ferrell's kids in Kicking & Screaming (2005), a co-starring role in the indie hit Little Manhattan (2005), and another co-starring role in Zathura: A Space Adventure (2005), which was originally conceived as a sequel to Jumanji (1995). Despite underperforming at the box office, \"Zathura\" helped earned for Josh his first Young Artist Award for \"Leading Young Actor\".\r\n\r\n2006 saw bigger returns for Josh's burgeoning film career with a role as one of Robin Williams' sons in the modest hit, R.V.: Runaway Vacation (2006). The following year, he landed his first breakthrough role in Bridge to Terabithia (2007), the kid-approved adaptation of Katherine Paterson's novel that co-starred AnnaSophia Robb, whose career was also taking off at this time.\r\n\r\nJosh starred as Brendan Fraser's nephew in another family-film hit, Journey to the Center of the Earth (2008), and he had a smaller role in the Crash-like drama, Fragments (2008), though by now his face and name were being used in movie-marketing materials. Though it wasn't a hit, Josh's character in Cirque du Freak: The Vampire's Assistant (2009) served as a major plot device early in the story.\r\n\r\nIn 2010, Josh co-starred in the critically-acclaimed film, The Kids Are All Right (2010), alongside Annette Bening, Julianne Moore, Mark Ruffalo, and Mia Wasikowska. The film received several awards and four Academy Award nominations, including Best Picture. Josh's performance as the youngest child in a family, led by two mothers, earned him acclaim from audiences and the industry, alike. Josh followed up with an expanded role in Journey 2: The Mysterious Island (2012), which saw Dwayne Johnson take over as the main character from Brendan Fraser. Between the star power and the allure of 3D, the sequel was a worldwide hit and a third installment is in development.\r\n\r\nWith the announcement that he would portray the beloved \"Peeta Mellark\" in The Hunger Games (2012), the film adaptation of the best-selling novel written by Suzanne Collins, Josh became an instant celebrity. In the wake of the movie's massive worldwide success, Detention (2011), a horror/comedy that Josh made before \"The Hunger Games\", was released. Josh was also an executive producer on that feature.\r\n\r\nBefore Josh reprises his role as \"Peeta\" in The Hunger Games: Catching Fire (2013), we will see him in the long-delayed remake of Red Dawn (2012); the omnibus 7 Days in Havana (2011) (aka \"7 Days in Havana\") (Josh's segment was directed by Benicio Del Toro); The Forger (2012) opposite Lauren Bacall, Alfred Molina, and Hayden Panettiere; and the animated Epic (2013) from Ice Age (2002) co-director (and voice of \"Scrat\"), Chris Wedge.", "https://i.kym-cdn.com/entries/icons/original/000/047/264/josh_hutcherson_whistle.jpg", "Josh Hutcherson" },
                    { 16, new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "lizabeth Lail stars in Blumhouse's box office hit, \"Five Nights At Freddys,\" based on the wildly popular video game series. She can also be seen in the upcoming indie film \"Gonzo Girl,\" directed by Patricia Arquette and starring Willem Dafoe. The film premiered at the Toronto Film Festival and is based on the critically acclaimed novel by Cheryl Della Pietra. Lail recently appeared in the comedy film \"Mack & Rita\" opposite Diane Keaton. Elizabeth is best known for her lead role of 'Beck' in Netflix's smash hit \"You\" and recently starred as 'Jenny' in NBC's drama series \"Ordinary Joe.\"\r\n\r\nElizabeth got her big break when she recreated the role of 'Anna' from Frozen on ABC's \"Once Upon A Time.\" She also starred in STX Entertainment's terrifying horror film, Countdown, the independent film Unintended, and in a recurring role in the HBO Max reboot of \"Gossip Girl\"", "https://m.media-amazon.com/images/M/MV5BZWVhMDM1NTYtMjdlNS00ODRkLThlMDUtZWY1NDRiZjcxYWJlXkEyXkFqcGdeQXVyNTIxMTU4Njc@._V1_.jpg", "Elizabeth Lail" },
                    { 17, new DateTime(1970, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Matthew Lillard was born in Lansing, Michigan, to Paula and Jeffrey Lillard. He lived with his family in Tustin, California, from first grade to high school graduation. The summer after high school, he was hired as an extra for Ghoulies III: Ghoulies Go to College (1991). Matthew was the MC of the Nickelodeon program SK8 TV (1990) in 1989. He attended the American Academy of Dramatic Arts in Pasedena, California. Along with a friend, Matthew started the Mean Street Ensemble theater company that functioned until 1991, when Matthew moved to New York to attend the theater school Circle in the Square.\r\n\r\nManager Bill Treusch got Matthew auditions for Serial Mom (1994). Matthew was cast as Chip and began another theater company called the Summoners.", "https://m.media-amazon.com/images/M/MV5BMjA2MzkyODc3MV5BMl5BanBnXkFtZTcwMjA0NTcyNw@@._V1_.jpg", "Matthew Lillard" },
                    { 18, new DateTime(1990, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bill Istvan Gunther Skarsgard is a Swedish actor, producer, director, writer, voice actor, and model. He is best known for portraying Pennywise the Dancing Clown in the supernatural horror films It (2017) and It Chapter Two (2019), based on Stephen King's novel of the same name. He also voiced the Deviant Kro in the Marvel Cinematic Universe film Eternals (2021).", "https://m.media-amazon.com/images/M/MV5BODBlNmRhODYtOWE2Ni00MTZmLWExMWYtMmRjYWNhNDRjNGU2XkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg", "Bill Skarsgård" },
                    { 19, new DateTime(2002, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "A native of Vancouver, British Columbia, actor Finn Wolfhard stars as Mike Wheeler in the critically acclaimed Netflix Original Series Stranger Things (2016). The hit series has received various accolades, including a Screen Actors Guild (SAG) Award for Outstanding Performance by an Ensemble in a Drama Series; two MTV Movie & TV Awards for Show of the Year; an AFI award for TV Program of the Year; and a Golden Globe nomination for Best Drama Television Series. To date, the world-famous series has received 30 Primetime Emmy Award nominations, including two for Outstanding Drama Series.\r\n\r\nHis first role was in the 2013 independent film Aftermath. After appearing in more independent films such as The Resurrection, Wolfhard moved into roles on television shows The 100 (2014) and Supernatural.\r\n\r\nIn September 2017, Wolfhard moved to the silver screen, playing the lead role of Ritchie Tozier in the film adaptation of the Stephen King acclaimed novel It (2017). Fans of the novel will remember Wolfhard's role as Trashmouth, part of the Losers Club. The film premiered to critical acclaim, breaking opening weekend box office records in its debut and going on to become the highest grossing horror movie ever. Wolfhard, along with his cast, received the Best On-Screen Team award for \"IT\" at the 2018 MTV Movie & TV Awards. Wolfhard also starred in Dog Days (2018) alongside Vanessa Hudgens and Nina Dobrev. He can also be heard in the Netflix animated series \"Carmen Sandiego,\" which released its second season in October 2019. Wolfhard reprises his role of Richie Tozier in New Line's blockbuster sequel It: Chapter Two (2019).\r\n\r\nIn May 2019, Wolfhard became the new face of Yves Saint Laurent's Fall/Winter 2019 Campaign. Wolfhard starred as Miles in Amblin's haunted house horror film The Turning (2020) opposite Mackenzie Davis and Brooklynn Prince. Wolfhard will star alongside Paul Rudd, Carrie Coon and McKenna Grace in Sony Pictures' highly anticipated Ghostbusters: Afterlife (2021), a new chapter in the \"Ghostbusters\" universe, from director Jason Reitman. Wolfhard stars alongside Oscar winning actress Julianne Moore in the comedy-drama feature When You Finish Saving the World (2022), written and directed by Jesse Eisenberg and produced by Emma Stone. The mother-son story is inspired by Eisenberg's upcoming Audible Original of the same name, which is debuting in 2020. Wolfhard is also set to star as a lead voice over in the upcoming animated series, \"NEW-GEN,\" based on the comic series distributed by Marvel and created by Chris Matonti, J.D. Matonti, and Julia Coppola.\r\n\r\nHe co-starred in Warner Bros & Amazon Studios' \"The Goldfinch,\" an adaptation of Donna Tartt's Pulitzer Prize winning & New York Times best-selling novel. Wolfhard played the role of Young Boris alongside an all-star cast including Ansel Elgort, Nicole Kidman, Sarah Paulson and Jeffrey Wright. Lastly, he voiced the character Pugsley Addams in MGM's The Addams Family (2019) animated film. He can also be heard in Netflix's animated series \"Carmen Sandiego,\" which released its second season in October 2019.\r\n\r\nIn addition to acting, Wolfhard has a passion for music and formed a garage-rock band called Calpurnia. Calpurnia recorded their debut EP which was released in June 2018. The band's first single \"City Boy\" debuted at No. 23 on Billboard's Alternative Digital Song Chart and hit No. 1 on Spotify's Global Viral 50 playlist. During the bands three-year run, Calpurnia toured across North America and Europe.\r\n\r\nIn the Fall of 2019, Wolfhard and drummer Malcolm Craig formed The Aubreys. In March 2020, The Aubreys released their first official EP entitled \"Soda & Pie.\" Wolfhard also used his growing platform to host an event and raise funds for Sweet Relief, an organization that helps musicians in need.", "https://m.media-amazon.com/images/M/MV5BYjlkNTdhNjYtYTFhNy00MTUxLWIwNTgtMTE5NTY5Y2I3MDc0XkEyXkFqcGdeQXVyNjY5NDgzNjQ@._V1_.jpg", "Finn Wolfhard" },
                    { 20, new DateTime(2003, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jaeden Martell is an American actor. He played the role of Bill Denbrough in the 2017 film adaptation of Stephen King's novel It and reprised the role in the film's 2019 sequel. He also appeared in the mystery film Knives Out (2019) and starred in the miniseries Defending Jacob (2020).\r\n\r\nMartell was born on January 4, 2003, in Philadelphia, Pennsylvania, the son of Wes Lieberher, a Los Angeles-based executive chef, and Angela Teresa Martell. His maternal grandmother, Chisun Martell, is Korean. He grew up in South Philadelphia and in 2011, when he was eight years old, he moved to Los Angeles.\r\n\r\nIn the first six years of his career, Martell was credited almost exclusively under his family name, Lieberher. In 2019, he switched to his mother's maiden name, Martell.\r\n\r\nMartell's first acting role was in a commercial for Hot Wheels. He appeared in several other commercials after that, including Google, Moneysupermarket.com, Liberty Mutual, Hyundai (for the 2013 Super Bowl), Verizon Fios and General Electric. His first major feature film role was in 2014's St. Vincent, where he starred alongside Bill Murray. Murray later recommended Martell to Cameron Crowe for the director's 2015 film Aloha. He played the title character in the 2017 film The Book of Henry. Martell received further recognition for his starring role as Bill Denbrough in the 2017 supernatural horror film It and its 2019 follow-up It Chapter Two.\r\n\r\nIn 2019, Martell was also a part of Rian Johnson's ensemble cast in the murder-mystery film Knives Out. In March 2019, now credited as Martell, he joined the cast of the Apple miniseries Defending Jacob, based on the William Landay novel of the same name. On April 30, 2020, in an Instagram Live interview with Teen Vogue, Martell confirmed that he had joined the cast of Tunnels in the role of Grayson Mitchell, the younger sibling of a victim of gun violence. The film does not have a set or confirmed release date.\r\n\r\nIn September 2021, Martell portrayed Morty Smith in a series of promotional interstitials for the two-part fifth season finale of Rick and Morty. In October 2021, he was cast as Craig in the Netflix film Mr. Harrigan's Phone written and directed by John Lee Hancock, based on the If It Bleeds novellas by Stephen King.\r\n\r\nJaden will meet with his audience in 2022 with Metal Lord, a Netflix production.\r\n\r\nThe young actor will also meet with the big screen again with the Stephen King adaptation 'Mr Harrigan's Phone', which is planned to be released in 2022.", "https://m.media-amazon.com/images/M/MV5BYmNkZjgwZmYtNzNjOC00ZGUxLTgzMmQtYWU0NDQyNmE4NWM5XkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_.jpg", "Jaeden Martell" },
                    { 21, new DateTime(1980, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Born Ryan Thomas Gosling on November 12, 1980, in London, Ontario, Canada, he is the son of Donna (Wilson), a secretary, and Thomas Ray Gosling, a traveling salesman. Ryan was the second of their two children, with an older sister, Mandi. His ancestry is French-Canadian, as well as English, Scottish, and Irish. The Gosling family moved to Cornwall, Ontario, where Ryan grew up and was home-schooled by his mother. He also attended Gladstone Public School and Cornwall Collegiate & Vocational School, where he excelled in Drama and Fine Arts. The family then relocated to Burlington, Ontario, where Ryan attended Lester B. Pearson High School.\r\n\r\nRyan first performed as a singer at talent contests with Mandi. He attended an open audition in Montreal for the TV series \"The Mickey Mouse Club\" (MMC (1989)) in January 1993 and beat out 17,000 other aspiring actors for a a spot on the show. While appearing on \"MMC\" for two years, he lived with co-star Justin Timberlake's family.\r\n\r\nThough he received no formal acting training, after \"MMC,\" Gosling segued into an acting career, appearing on the TV series Young Hercules (1998) and Breaker High (1997), as well as the films The Slaughter Rule (2002), Murder by Numbers (2002), and Remember the Titans (2000). He first attracted serious critical attention with his performance as the Jewish neo-Nazi in the controversial film The Believer (2001), which won the Grand Jury Prize at the 2001 Sundance Film Festival. He was cast in the part by writer-director Henry Bean, who believed that Gosling's strict upbringing gave him the insight to understand the character Danny, whose obsessiveness with the Judaism he was born into turns to hatred. He was nominated for an Independent Spirit Award as Best Male Lead in 2002 for the role and won the Golden Aries award from the Russian Guild of Film Critics.\r\n\r\nAfter appearing in the sleeper The Notebook (2004) in 2004, Gosling won the dubious honor of being named one of the 50 Hottest Bachelors by People Magazine. More significantly, he was named the Male Star of Tomorrow at the 2004 Show West convention of movie exhibitors.\r\n\r\nGosling reached a summit of his profession with his performance in Half Nelson (2006), which garnered him an Academy Award nomination as Best Actor. In a short time, he has established himself as one of the finest actors of his generation. Throughout the subsequent decade, he has become all three of an internet fixation, a box office star, and a critical darling, having headlined Blue Valentine (2010), Crazy, Stupid, Love. (2011), Drive (2011), The Ides of March (2011), The Place Beyond the Pines (2012), The Nice Guys (2016), and La La Land (2016). In 2017, he starred in the long-awaited science fiction sequel Blade Runner 2049 (2017), with Harrison Ford.\r\n\r\nRyan has two children with his partner, actress Eva Mendes.", "https://m.media-amazon.com/images/M/MV5BMTQzMjkwNTQ2OF5BMl5BanBnXkFtZTgwNTQ4MTQ4MTE@._V1_.jpg", "Ryan Gosling" },
                    { 22, new DateTime(1956, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bryan Lee Cranston was born on March 7, 1956 in Hollywood, California, to Audrey Peggy Sell, a radio actress, and Joe Cranston, an actor and former amateur boxer. His maternal grandparents were German, and his father was of Irish, German, and Austrian-Jewish ancestry. He was raised in the Canoga Park neighborhood of Los Angeles, and also stayed with his grandparents, living on their poultry farm in Yucaipa. Cranston's father walked out on the family when Cranston was eleven, and they did not see each other again until 11 years later, when Cranston and his brother decide to track down their father.\r\n\r\nCranston is known for his roles as Walter White on the AMC crime drama Breaking Bad (2008), Hal on the Fox situation comedy Malcolm in the Middle (2000), and Dr. Tim Whatley on five episodes of the NBC situation comedy Seinfeld (1989). For his role on \"Breaking Bad\", he won the Primetime Emmy Award for Outstanding Lead Actor in a Drama Series four times (2008-2010, 2014), including three consecutive wins. After becoming one of the producers during the series' fourth and fifth seasons, he also won the Primetime Emmy Award for Outstanding Drama Series twice.\r\n\r\nIn June 2014, Cranston won the Tony Award for Best Actor in a Play for his portrayal of Lyndon B. Johnson in the play \"All the Way\" on Broadway. He reprised the role of Lyndon Johnson in the television adaptation All the Way (2016), which earned him widespread praise by critics. For the biographical drama Trumbo (2015), he earned widespread acclaim and was nominated for the Academy Award for Best Actor. Cranston also appeared in several acclaimed films, such as Saving Private Ryan (1998), Little Miss Sunshine (2006), Drive (2011), Argo (2012) and Godzilla (2014). In 2019, he starred with Kevin Hart in the box office hit The Upside (2017).\r\n", "https://m.media-amazon.com/images/M/MV5BMTA2NjEyMTY4MTVeQTJeQWpwZ15BbWU3MDQ5NDAzNDc@._V1_.jpg", "Bryan Cranston" },
                    { 23, new DateTime(1985, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carey Hannah Mulligan is a British actress. She was born May 28, 1985, in Westminster, London, England, to Nano (Booth), a university lecturer, and Stephen Mulligan, a hotel manager. Her mother is from Llandeilo, Wales, and Carey also has Irish and English ancestry.\r\n\r\nHer first major appearance was playing Kitty Bennet in Pride & Prejudice (2005) alongside Keira Knightley, Judi Dench, and Donald Sutherland. Carey also played orphan Ada Clare in the BBC television series Bleak House (2005).\r\n\r\nCarey has said that her passion and love for acting was first kindled at her old school Woldingham School, where she took part in a school production of \"Sweet Charity\" in her final year, and where she was also a student head of drama.\r\n\r\nCarey is married to musician Marcus Mumford of Mumford & Sons.", "https://m.media-amazon.com/images/M/MV5BNjQ1NGM2ODUtODc3Ny00ZjdhLTljNzEtMmY2M2M2MDY2Y2IzXkEyXkFqcGdeQXVyNzg5MzIyOA@@._V1_.jpg", "Carey Mulligan" },
                    { 24, new DateTime(1990, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Margot Elise Robbie was born on July 2, 1990 in Dalby, Queensland, Australia to Scottish parents. Her mother, Sarie Kessler, is a physiotherapist, and her father, is Doug Robbie. She comes from a family of four children, having two brothers and one sister. She graduated from Somerset College in Mudgeeraba, Queensland, Australia, a suburb in the Gold Coast hinterland of South East Queensland, where she and her siblings were raised by their mother and spent much of her time at the farm belonging to her grandparents. In her late teens, she moved to Melbourne, Victoria, Australia to pursue an acting career.\r\n\r\nFrom 2008-2010, Robbie played the character of Donna Freedman in the long-running Australian soap opera, Neighbours (1985), for which she was nominated for two Logie Awards. She set off to pursue Hollywood opportunities, quickly landing the role of Laura Cameron on the short-lived ABC series, Pan Am (2011). She made her big screen debut in the film, About Time (2013).\r\n\r\nRobbie rose to fame co-starring alongside Leonardo DiCaprio, portraying the role of Naomi Lapaglia in Martin Scorsese's Oscar nominated film, The Wolf of Wall Street (2013). She was nominated for a Breakthrough Performance MTV Movie Award, and numerous other awards.\r\n\r\nIn 2014, Robbie founded her own production company, LuckyChap Entertainment. She also appeared in the World War II romantic-drama film, Suite Française (2014). She starred in Focus (2015) and Z for Zachariah (2015), and made a cameo in The Big Short (2015).\r\n\r\nIn 2016, she married Tom Ackerley in Byron Bay, New South Wales, Australia.\r\n\r\nShe starred as Jane Porter in The Legend of Tarzan (2016), Tanya Vanderpoel in Whiskey Tango Foxtrot (2016) and as DC comics villain Harley Quinn in Suicide Squad (2016), for which she was nominated for a Teen Choice Award, and many other awards.\r\n\r\nShe portrayed figure skater Tonya Harding in the biographical film I, Tonya (2017), receiving critical acclaim and a Golden Globe Award nomination for Best Actress - Motion Picture Comedy or Musical.", "https://m.media-amazon.com/images/M/MV5BMTgxNDcwMzU2Nl5BMl5BanBnXkFtZTcwNDc4NzkzOQ@@._V1_FMjpg_UX1000_.jpg", "Margot Robbie" },
                    { 25, new DateTime(1984, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kathryn McKinnon Berthold (born January 6, 1984), known professionally as Kate McKinnon, is an American actress and comedienne, who is best known as a regular cast member on Saturday Night Live and The Big Gay Sketch Show, and for playing the role of Dr. Jillian Holtzmann in the 2016 Ghostbusters reboot.\r\n\r\nMcKinnon is known for her character work and celebrity impressions of pop singer Justin Bieber, comedian television host Ellen DeGeneres, and political figures Hillary Clinton, Kellyanne Conway, Elizabeth Warren, Betsy DeVos, Ruth Bader Ginsburg, Robert Mueller, and Jeff Sessions. She has been nominated for five Primetime Emmy Awards; one for Outstanding Original Music and Lyrics and four for Outstanding Supporting Actress in a Comedy Series, winning in 2016 and 2017.\r\n\r\nKathryn McKinnon Berthold was born and raised in the Long Island town of Sea Cliff, New York. She is the daughter of Laura Campbell, a parent educator, and Michael Thomas Berthold, an architect. She has a younger sister, Emily. Her father died when she was 18 years old.\r\n\r\nAs a child, McKinnon played several instruments. She started playing the piano when she was 5 years old, the cello when she was 12, and taught herself how to play the guitar when she was 15. She graduated from North Shore High School in 2002, and from Columbia University in 2006 with a theater major, where she co-founded a comedy group, Tea Party, which focused on musical improv comedy. At Columbia, she starred in three Varsity shows: V109 \"Dial D for Deadline\", V110 \"Off-Broadway\" and V111 \"The Sound of Muses\". She was also a member of Prangstgrüp, a student comedy group who set up and recorded elaborate college pranks.\r\n\r\nIn 2007, McKinnon joined the original cast of Logo TV's The Big Gay Sketch Show, where she was a cast member for all three seasons. Since 2008, she has performed live sketch comedy regularly at the Upright Citizens Brigade Theatre in New York City. She has also worked as a voice-over actress, and has voiced characters for series such as The Venture Bros., Robotomy, and Ugly Americans. In 2009, McKinnon won a Logo NewNowNext Award for Best Rising Comic. She was nominated for an ECNY Emerging Comic Award in 2010. In 2014, she appeared in the Kennedy Center Honors as part of a tribute to Lily Tomlin. In 2016, she starred in the reboot Ghostbusters, alongside Melissa McCarthy, and fellow SNL cast members Kristen Wiig and Leslie Jones. In 2017, McKinnon is attached to star in Amblin Entertainment's Lunch Witch, an adaptation of a young adult graphic novel by Deb Lucke. She has been set to play the title role of Grunhilda, an out-of-work witch who takes a job in a school cafeteria to make ends meet. McKinnon voices the character of Ms. Frizzle in the reboot of the Magic School Bus children's series.\r\n\r\nMcKinnon debuted as a featured player on Saturday Night Live on April 7, 2012. She was promoted to repertory status in season 39 in 2013. Following the departure of Vanessa Bayer, McKinnon is now the longest serving female cast member.\r\n\r\nIn 2013, McKinnon was nominated for an Emmy for Best Supporting Actress, Comedy. McKinnon won the 2014 American Comedy Award for Best Supporting Actress, TV for her work on SNL. In 2014, she was nominated for an Emmy Award for Outstanding Supporting Actress in a Comedy Series, as well as for Outstanding Original Music and Lyrics along with four of her colleagues for the song \"(Do It On My) Twin Bed\". She was nominated for an Emmy for Outstanding Supporting Actress in a Comedy Series for the second time in 2015. She eventually won the very next year, becoming the first actor from SNL to win the award since 1993.\r\n\r\nMcKinnon began appearing as Hillary Clinton on the series leading up to the 2016 presidential election. The real Clinton appeared alongside her in a sketch during the show's season 41 premiere. McKinnon has said that her impression of Hillary Clinton comes from a place of deep admiration, and that \"[she] unequivocally want her to win\" the 2016 presidential election. On November 12, 2016, which was the first show after Clinton's loss in the election, she reprised the role to open the show with a solo performance of \"Hallelujah\" by Leonard Cohen, whose death was announced two days before her performance. After the election, McKinnon began to impersonate Kellyanne Conway alongside Alec Baldwin as Trump. On February 11, she debuted her impression of Elizabeth Warren during Weekend Update and Jeff Sessions in the cold open.", "https://m.media-amazon.com/images/M/MV5BMjQwMzEwMDQ2NF5BMl5BanBnXkFtZTgwMzU4NTY4NjE@._V1_FMjpg_UX1000_.jpg", "Kate McKinnon" },
                    { 26, new DateTime(1942, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Harrison Ford was born on July 13, 1942 in Chicago, Illinois, to Dorothy (Nidelman), a radio actress, and Christopher Ford (born John William Ford), an actor turned advertising executive. His father was of Irish and German ancestry, while his maternal grandparents were Jewish emigrants from Minsk, Belarus. Harrison was a lackluster student at Maine Township High School East in Park Ridge Illinois (no athletic star, never above a C average). After dropping out of Ripon College in Wisconsin, where he did some acting and later summer stock, he signed a Hollywood contract with Columbia and later Universal. His roles in movies and television (Ironside (1967), The Virginian (1962)) remained secondary and, discouraged, he turned to a career in professional carpentry. He came back big four years later, however, as Bob Falfa in American Graffiti (1973). Four years after that, he hit colossal with the role of Han Solo in Star Wars: Episode IV - A New Hope (1977). Another four years and Ford was Indiana Jones in Raiders of the Lost Ark (1981).\r\n\r\nFour years later and he received Academy Award and Golden Globe nominations for his role as John Book in Witness (1985). All he managed four years after that was his third starring success as Indiana Jones; in fact, many of his earlier successful roles led to sequels as did his more recent portrayal of Jack Ryan in Patriot Games (1992). Another Golden Globe nomination came his way for the part of Dr. Richard Kimble in The Fugitive (1993). He is clearly a well-established Hollywood superstar. He also maintains an 800-acre ranch in Jackson Hole, Wyoming.\r\n\r\nFord is a private pilot of both fixed-wing aircraft and helicopters, and owns an 800-acre (3.2 km2) ranch in Jackson, Wyoming, approximately half of which he has donated as a nature reserve. On several occasions, Ford has personally provided emergency helicopter services at the request of local authorities, in one instance rescuing a hiker overcome by dehydration. Ford began flight training in the 1960s at Wild Rose Idlewild Airport in Wild Rose, Wisconsin, flying in a Piper PA-22 Tri-Pacer, but at $15 an hour, he could not afford to continue the training. In the mid-1990s, he bought a used Gulfstream II and asked one of his pilots, Terry Bender, to give him flying lessons. They started flying a Cessna 182 out of Jackson, Wyoming, later switching to Teterboro, New Jersey, flying a Cessna 206, the aircraft he soloed in. Ford is an honorary board member of the humanitarian aviation organization Wings of Hope.\r\n\r\nOn March 5, 2015, Ford's plane, believed to be a Ryan PT-22 Recruit, made an emergency landing on the Penmar Golf Course in Venice, California. Ford had radioed in to report that the plane had suffered engine failure. He was taken to Ronald Reagan UCLA Medical Center, where he was reported to be in fair to moderate condition. Ford suffered a broken pelvis and broken ankle during the accident, as well as other injuries.", "https://m.media-amazon.com/images/M/MV5BMTY4Mjg0NjIxOV5BMl5BanBnXkFtZTcwMTM2NTI3MQ@@._V1_FMjpg_UX1000_.jpg", "Harrison Ford" },
                    { 27, new DateTime(1969, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "David Michael Bautista, Jr. was born on January 18, 1969 in Washington, D.C., to Donna Raye (Mullins) and David Michael Bautista, a hairdresser. He has Filipino and Greek ancestry.\r\n\r\nWhen WCW officials told him he'd never make it in sports entertainment, Bautista pushed himself to achieve his dream of being a Superstar. In May 2002, he made his debut on SmackDown using the ring name Batista, but it wasn't until a move to Raw and two victories over Kane that \"The Animal\" began to make noise in the WWE Universe. The wins impressed Ric Flair and Triple H, who were looking to align themselves with the industry's brightest new stars. After a lengthy search, they identified Randy Orton and Batista. Collectively the four Superstars became known as Evolution.\r\n\r\nBatista earned his first championship alongside \"The Nature Boy\" when the duo captured the WWE Tag Team Championships in December 2003. As Evolution dominated WWE, Batista started to emerge from the shadows of Triple H and Ric Flair. By the time Batista won the 2005 Royal Rumble Match, World Heavyweight Champion Triple H viewed him as a serious threat to his title.\r\n\r\nAfter a triceps injury at the hands of Mark Henry forced Batista to relinquish the title in January 2006, he vowed to return. Batista successfully regained the World Heavyweight Championship at Survivor Series in 2006. Four months into his second reign, Batista faced the Undertaker at WrestleMania 23. \"The Animal\" took Undertaker to the limit, but was unable to stop the streak of \"The Deadman\" at WrestleMania. Though disappointed, Batista stayed hungry and always managed to keep himself in the championship hunt for the rest of his career.\r\n\r\nAt Bragging Rights in 2009, Batista shocked the world when he blamed Rey Mysterio for a loss to Undertaker, then attacked his former tag team partner. \"The Animal\" then became locked in a tense rivalry with another former friend, John Cena, over the WWE Championship. The grueling match at Over the Limit led to a wheelchair-bound Batista declaring \"I quit!\" the following night on Raw before fading from the WWE Universe in May 2010. Following his departure from WWE, Bautista appeared opposite Vin Diesel in the Universal film Riddick (2013) and RZA's feature directorial debut The Man with the Iron Fists (2012), in which he played the villainous Brass Body and starred opposite Russell Crowe and Lucy Liu. His other film credits include The Scorpion King 3: Battle for Redemption (2012), where he played Argomael; the action film House of the Rising Sun (2011); and Wrong Side of Town (2010) opposite rapper Ja Rule.\r\n\r\nTwo years later, he joined MMA and won his first professional MMA fight. In January 2014, he made his long awaited return to the WWE, before quitting a second time in June of that same year. He did this in order to promote Guardians of the Galaxy (2014), which was released on August 1, 2014, and starred Chris Pratt, Benicio Del Toro, Zoe Saldana, and Djimon Hounsou, alongside Bautista.\r\n\r\nHe will shoot Kickboxer: Vengeance (2016), directed by John Stockwell, and co-starring martial artist Alain Moussi and UFC fighter Georges St-Pierre. The remake of the 1989 Jean-Claude Van Damme film, Kickboxer (1989) is about two brothers David and Kurt Sloan; When David wins the Karate World Championship, a promoter lures him to Hong Kong, despite his brother's protestations that the man is a crook. When Kurt travels to Thailand to meet his brother, he discovers he has died and seeks his revenge.\r\n\r\nAfter starring in films such as, Guardians of the Galaxy: Vol. 2 (2017), Blade Runner 2049 (2017), Avengers: Infinity War (2018), Hotel Artemis (2018), Escape Plan II (2018), and Final Score (2018), he made a special guest appearance on WWF SmackDown! (1999) for it's 1000 episode reuniting with his former Evolution members Triple H, Randy Orton, and Ric Flair on October 16, 2018. The following year on February 25, 2019, he made his return to WWE Monday Night RAW (1993) when he attacked Ric Flair on his 70th birthday at the end of the episode sending a message to Triple H that would ultimately lead to a No Holds Barred match for WWE WrestleMania 35 (2019). Batista added the stipulation that if he wins the match, Triple H will have to retire from in-ring competition. As a result, Triple H was finally able to beat Batista for the first time and won the match, which ultimately led to Batista announcing his official retirement from wrestling in the WWE. Following his retirement, he will continue with his career as an actor in Hollywood.\r\n\r\nHis next films scheduled for release will be; Stuber (2019), Avengers: Endgame (2019), Escape Plan 3 (2019), and My Spy (2020). He is one of many professional wrestlers to make the smooth transition from wrestling into the entertainment world.", "https://m.media-amazon.com/images/M/MV5BNTZkYzU0ZGUtZTk1MC00MzJjLWFmMzItY2M0ODY1ZmI2OGQ0XkEyXkFqcGdeQXVyMjI0MjgwNjc@._V1_.jpg", "Dave Bautista" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
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
                    { new Guid("075af806-fb6f-476d-804f-baecbd15bdd3"), "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_FMjpg_UY2048_.jpg", false, "The Dark Knight", 9.0, new DateTime(2008, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("13b84726-1968-4206-9f4b-856a4ba9998a"), "Two strangers awaken in a room with no recollection of how they got there, and soon discover they're pawns in a deadly game perpetrated by a notorious serial killer.", "https://m.media-amazon.com/images/M/MV5BM2M1MzI1MWYtYmM2ZC00OWY3LTk0ZGMtNmRkNzU1NzEzMWE5XkEyXkFqcGdeQXVyODUwOTkwODk@._V1_FMjpg_UX1000_.jpg", false, "Saw", 7.5999999999999996, new DateTime(2004, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f2e3281-95ea-4e2e-8693-d4983c7907da"), "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UX1055_.jpg", false, "Pulp Fiction", 8.9000000000000004, new DateTime(1994, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2ca61990-fe17-483c-863d-442ee4c0acad"), "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.", "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1200_.jpg", false, "The Shawshank Redemption", 9.3000000000000007, new DateTime(1994, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("30da4459-9475-404d-92fb-9124cff7cfa6"), "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UY1982_.jpg", false, "The Godfather", 9.1999999999999993, new DateTime(1972, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3d777bdc-ded7-42d2-b0a6-fc378eb32173"), "A mysterious Hollywood action film stuntman gets in trouble with gangsters when he tries to help his neighbor's husband rob a pawn shop while serving as his getaway driver.\r\n\r\n", "https://m.media-amazon.com/images/M/MV5BZjY5ZjQyMjMtMmEwOC00Nzc2LTllYTItMmU2MzJjNTg1NjY0XkEyXkFqcGdeQXVyNjQ1MTMzMDQ@._V1_FMjpg_UX1000_.jpg", false, "Drive", 7.7999999999999998, new DateTime(2011, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("506f4021-595b-4637-bba0-e2b88377549e"), "In the summer of 1989, a group of bullied kids band together to destroy a shape-shifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town.\r\n\r\n", "https://m.media-amazon.com/images/M/MV5BZDVkZmI0YzAtNzdjYi00ZjhhLWE1ODEtMWMzMWMzNDA0NmQ4XkEyXkFqcGdeQXVyNzYzODM3Mzg@._V1_.jpg", false, "It", 7.2999999999999998, new DateTime(2017, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "Name", "Rating", "ReleaseDate" },
                values: new object[] { new Guid("75cc9cfd-225c-4f69-8870-3986e74a88a4"), "Young Blade Runner K's discovery of a long-buried secret leads him to track down former Blade Runner Rick Deckard, who's been missing for thirty years.", "https://m.media-amazon.com/images/M/MV5BNzA1Njg4NzYxOV5BMl5BanBnXkFtZTgwODk5NjU3MzI@._V1_FMjpg_UX1000_.jpg", false, "Blade Runner 2049", 8.0, new DateTime(2017, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "Name", "Rating", "ReleaseDate" },
                values: new object[] { new Guid("e054427d-ca00-4bfc-921e-ae86fbf621ef"), "Barbie and Ken are having the time of their lives in the colorful and seemingly perfect world of Barbie Land. However, when they get a chance to go to the real world, they soon discover the joys and perils of living among humans.\r\n\r\n", "https://m.media-amazon.com/images/M/MV5BNjU3N2QxNzYtMjk1NC00MTc4LTk1NTQtMmUxNTljM2I0NDA5XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_FMjpg_UX1000_.jpg", false, "Barbie", 6.9000000000000004, new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "Name", "Rating", "ReleaseDate" },
                values: new object[] { new Guid("fea8731c-71a3-4980-b1ee-aa44500953a6"), "A troubled security guard begins working at Freddy Fazbear's Pizza. During his first night on the job, he realizes that the night shift won't be so easy to get through. Pretty soon he will unveil what actually happened at Freddy's.", "https://m.media-amazon.com/images/M/MV5BNmNlZWI4MDQtMzFlYS00NzJmLTkwZjItZWVmNmJjZGYxNDA1XkEyXkFqcGdeQXVyMTM0NTUzNDIy._V1_FMjpg_UX1000_.jpg", false, "Five Nights at Freddy's", 5.5, new DateTime(1994, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovieCharacters_ActorId",
                table: "ActorMovieCharacters",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovies_ActorId",
                table: "ActorMovies",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_MovieId",
                table: "MovieGenres",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieMovieCharacters_MovieId",
                table: "MovieMovieCharacters",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_ApplicationUserId",
                table: "UserReviews",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_MovieId",
                table: "UserReviews",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovieCharacters");

            migrationBuilder.DropTable(
                name: "ActorMovies");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MovieGenres");

            migrationBuilder.DropTable(
                name: "MovieMovieCharacters");

            migrationBuilder.DropTable(
                name: "UserReviews");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "MovieCharacters");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
