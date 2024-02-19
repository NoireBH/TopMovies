using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data.Models;

namespace TopMovies.Data.Configurations
{
    public class ActorEntityConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.HasData(SeedActors());
        }

        private Actor[] SeedActors()
        {

            var actors = new HashSet<Actor>();

            Actor actor;

            actor = new Actor()
            {
                Id = 1,
                Name = "Morgan Freeman",
                Description = "With an authoritative voice and calm demeanor, this ever popular American actor has grown into one of the most respected figures in modern US cinema. Morgan was born on June 1, 1937 in Memphis, Tennessee, to Mayme Edna (Revere), a teacher, and Morgan Porterfield Freeman, a barber. The young Freeman attended Los Angeles City College before serving several years in the US Air Force as a mechanic between 1955 and 1959. His first dramatic arts exposure was on the stage including appearing in an all-African American production of the exuberant musical Hello, Dolly!.",
                ImageUrl = "https://image.tmdb.org/t/p/w500/jPsLqiYGSofU4s6BjrxnefMfabb.jpg",
                YearBorn = new DateTime(1997, 6, 1)
            };

            actor = new Actor()
            {
                Id = 2,
                Name = "Tim Robbins",
                Description = "Born in West Covina, California, but raised in New York City, Tim Robbins is the son of former The Highwaymen singer Gil Robbins and actress Mary Robbins (née Bledsoe). Robbins studied drama at UCLA, where he graduated with honors in 1981. That same year, he formed the Actors' Gang theater group, an experimental ensemble that expressed radical political observations through the European avant-garde form of theater. He started film work in television movies in 1983, but hit the big time in 1988 with his portrayal of dimwitted fastball pitcher \"Nuke\" Laloosh in Bull Durham (1988). Tall with baby-faced looks, he has the ability to play naive and obtuse (Cadillac Man (1990) and The Hudsucker Proxy (1994)) or slick and shrewd (The Player (1992) and Bob Roberts (1992)).",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI1OTYxNzAxOF5BMl5BanBnXkFtZTYwNTE5ODI4._V1_FMjpg_UX1000_.jpg",
                YearBorn = new DateTime(1958, 10, 16)
            };

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 3,
                Name = "Clancy Brown",
                Description = "A tall, wavy-haired US actor with a deep, resonant voice, Clancy Brown has proven himself a versatile performer with first-class contributions to theatre, feature films, television series and even animation.\r\n\r\nClarence J. Brown III was born in 1959 in Urbana, Ohio, to Joyce Helen (Eldridge), a concert pianist, conductor, and composer, and Clarence J. \"Bud\" Brown, Jr., who helped manage the Brown Publishing Company, the family-owned newspaper started by Clancy's grandfather, Clarence J. Brown. Clancy's father and grandfather were also Republican congressmen from the same Ohio district, and Clancy spent much of his youth in close proximity to Washington, D.C. He plied his dramatic talents in the Chicago theatre scene before moving onto feature film with a sinister debut performance bullying Sean Penn inside a youth reformatory in Bad Boys (1983). He portrayed Viktor the Monster in the unusual spin on the classic Frankenstein story in The Bride (1985), before scoring one of his best roles to date as the evil Kurgan hunting fellow immortals Christopher Lambert and Sean Connery across four centuries of time in Highlander (1986).\r\n\r\nBrown played a corrupt American soldier in the Walter Hill-directed hyper-violent action film Extreme Prejudice (1987), another deranged killer in Deadly Pursuit (1988) and a brutal prison guard, who eventually somewhat \"befriends\" wrongfully convicted banker Tim Robbins, in the moving The Shawshank Redemption (1994). His superb vocal talents were in demand, and he contributed voices to animated series, including Mortal Kombat: Defenders of the Realm (1995), Street Sharks (1994), Gargoyles (1994) and Superman: The Animated Series (1996). Brown then landed two more plum roles, one as a \"tough-as-nails\" drill sergeant in the science fiction thriller Starship Troopers (1997), and the other alongside Robin Williams in the Disney comedy Flubber (1997).\r\n\r\nThe video gaming industry took notice of Clancy's vocal abilities, too, and he has contributed voices to several top selling video games, including Crash Bandicoot: The Wrath of Cortex (2001), Lands of Lore III (1999), Star Wars: Bounty Hunter (2002) and Crash Nitro Kart (2003). His voice is also the character of cranky crustacean Mr. Eugene H. Krabs in the highly successful SpongeBob SquarePants (1999) animated series and films, and he contributed voices to The Batman (2004), Jackie Chan Adventures (2000) and Justice League (2001) animated series. A popular and friendly personality, Clancy Brown continues to remain busy both through his vocal and acting talents in Hollywood.",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTUxODY3NjAzMF5BMl5BanBnXkFtZTcwMTQ5MjYwNg@@._V1_FMjpg_UX1000_.jpg",
                YearBorn = new DateTime(1959, 1, 5)
            };

            actors.Add(actor);

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 4,
                Name = "Al Pacino",
                Description = "Alfredo James \"Al\" 'Pacino established himself as a film actor during one of cinema's most vibrant decades, the 1970s, and has become an enduring and iconic figure in the world of American movies.He was born April 25, 1940 in Manhattan, New York City, to Italian-American parents, Rose (nee Gerardi) and Sal Pacino. They divorced when he was young. His mother moved them into his grandparents' home in the South Bronx. Pacino found himself often repeating the plots and voices of characters he had seen in the movies. Bored and unmotivated in school, he found a haven in school plays, and his interest soon blossomed into a full-time career. Starting onstage, he went through a period of depression and poverty, sometimes having to borrow bus fare to succeed to auditions. He made it into the prestigious Actors Studio in 1966, studying under Lee Strasberg, creator of the Method Approach that would become the trademark of many 1970s-era actors.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Al_Pacino_2016_%2830401544240%29.jpg/640px-Al_Pacino_2016_%2830401544240%29.jpg",
                YearBorn = new DateTime(1940, 4, 25)
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 5,
                Name = "Diane Keaton",
                Description = "Diane Keaton was born Diane Hall in Los Angeles, California, to Dorothy Deanne (Keaton), an amateur photographer, and John Newton Ignatius \"Jack\" Hall, a civil engineer and real estate broker. She studied Drama at Santa Ana College, before dropping out in favor of the Neighborhood Playhouse in New York. After appearing in summer stock for several months, she got her first major stage role in the Broadway rock musical \"Hair\". As understudy to the lead, she gained attention by not removing any of her clothing. In 1968, Woody Allen cast her in his Broadway play \"Play It Again, Sam,\" which had a successful run. It was during this time that she became involved with Allen and appeared in a number of his films. The first one was Play It Again, Sam (1972), the screen adaptation of the stage play. That same year Francis Ford Coppola cast her as Kay in the Oscar-winning The Godfather (1972), and she was on her way to stardom. She reprized that role in the film's first sequel, The Godfather Part II (1974). She then appeared with Allen again in Sleeper (1973) and Love and Death (1975).\r\n\r\nIn 1977, she broke away from her comedy image to appear in the chilling Mr. Goodbar (1977), which won her a Golden Globe nomination. It was the same year that she appeared in what many regard as her best performance, in the title role of Annie Hall (1977), which Allen wrote specifically for her (her real last name is Hall, and her nickname is Annie), and what an impact she made. She won the Oscar and the British Award for Best Actress, and Allen won the Directors Award from the DGA. She started a fashion trend with her unisex clothes and was the poster girl for a lot of young males. Her mannerisms and awkward speech became almost a national craze. The question being asked, though, was, \"Is she just a lightweight playing herself, or is there more depth to her personality?\" For whatever reason, she appeared in but one film a year for the next two years and those films were by Allen. When they broke up she was next involved with Warren Beatty and appeared in his film Reds (1981), as the bohemian female journalist Louise Bryant. For her performance, she received nominations for the Academy Award and the Golden Globe. For the rest of the 1980s she appeared infrequently in films but won nominations in three of them. Attempting to break the typecasting she had fallen into, she took on the role of a confused, somewhat naive woman who becomes involved with Middle Eastern terrorists in The Little Drummer Girl (1984). To offset her lack of movie work, Diane began directing. She directed the documentary Heaven (1987), as well as some music videos. For television she directed an episode of the popular, but strange, Twin Peaks (1990).",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTY5NDI5OTEyOF5BMl5BanBnXkFtZTgwMzU4NDI1NzM@._V1_FMjpg_UX1000_.jpg",
                YearBorn = new DateTime(1946, 1, 5)
            };

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 6,
                Name = "Gianni Russo",
                Description = "With a singularly nebulous background, which, by his account, included stints as a Las Vegas nightclub emcee, radio personality and jewelry tycoon, and with comparatively little acting experience, Gianni Russo won the role of Carlo Rizzi in The Godfather (1972) on the basis of his screen test. Since then, Russo has remained busy as an actor, mostly playing assorted \"wiseguys\" and Mafia types. He appeared again with Marlon Brando in a small role in The Freshman (1990) where Brando parodied his Don Corleone role to good effect.",
                ImageUrl = "Gianni Russo",
                YearBorn = new DateTime(1943, 9, 12)
            };

            actor = new Actor()
            {
                Id = 7,
                Name = "Christian Bale",
                Description = "Christian Charles Philip Bale was born in Pembrokeshire, Wales, UK on January 30, 1974, to English parents Jennifer \"Jenny\" (James) and David Bale. His mother was a circus performer and his father, who was born in South Africa, was a commercial pilot. The family lived in different countries throughout Bale's childhood, including England, Portugal, and the United States. Bale acknowledges the constant change was one of the influences on his career choice.\r\n\r\nHis first acting job was a cereal commercial in 1983; amazingly, the next year, he debuted on the West End stage in \"The Nerd\". A role in the 1986 NBC mini-series Anastasia: The Mystery of Anna (1986) caught Steven Spielberg's eye, leading to Bale's well-documented role in Empire of the Sun (1987). For the range of emotions he displayed as the star of the war epic, he earned a special award by the National Board of Review for Best Performance by a Juvenile Actor.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Christian_Bale_2009.jpg/800px-Christian_Bale_2009.jpg",
                YearBorn = new DateTime(1974, 1, 30)
            };

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 8,
                Name = "Heath Ledger",
                Description = "When hunky, twenty-year-old heart-throb Heath Ledger first came to the attention of the public in 1999, it was all too easy to tag him as a \"pretty boy\" and an actor of little depth. He spent several years trying desperately to sway this image, but this was a double-edged sword. His work comprised nineteen films, including 10 Things I Hate About You (1999), The Patriot (2000), A Knight's Tale (2001), Monster's Ball (2001), Ned Kelly (2003), The Brothers Grimm (2005), Lords of Dogtown (2005), Brokeback Mountain (2005), Casanova (2005), Candy (2006), I'm Not There (2007), The Dark Knight (2008) and The Imaginarium of Doctor Parnassus (2009). He also produced and directed music videos and aspired to be a film director.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ea/Heath_Ledger_%282%29.jpg",
                YearBorn = new DateTime(1979, 4, 4)
            };

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 9,
                Name = "Cillian Murphy",
                Description = "",
                ImageUrl = "",
                YearBorn = new DateTime(1976, 5 ,25)
            };

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 10,
                Name = "Samuel L. Jackson",
                Description = "Samuel L. Jackson is an American producer and highly prolific actor, having appeared in over 100 films, including Die Hard: With a Vengeance (1995), Unbreakable (2000), Shaft (2000), The 51st State (2001), Black Snake Moan (2006), Snakes on a Plane (2006), and the Star Wars prequel trilogy (1999-2005), as well as the Marvel Cinematic Universe.\r\n\r\nSamuel Leroy Jackson was born in Washington, D.C., to Elizabeth (Montgomery) and Roy Henry Jackson. He was raised by his mother, a factory worker, and his grandparents. At Morehouse College, Jackson was active in the black student movement. In the seventies, he joined the Negro Ensemble Company (together with Morgan Freeman). In the eighties, he became well-known after three movies made by Spike Lee: Do the Right Thing (1989), Mo' Better Blues (1990) and Jungle Fever (1991). He achieved prominence and critical acclaim in the early 1990s with films such as Patriot Games (1992), Amos & Andrew (1993), True Romance (1993), Jurassic Park (1993), and his collaborations with director Quentin Tarantino, including Pulp Fiction (1994), Jackie Brown (1997), and later Django Unchained (2012). Going from supporting player to leading man, his performance in Pulp Fiction (1994) gave him an Oscar nomination for his character Jules Winnfield, and he received a Silver Berlin Bear for his part as Ordell Robbi in Jackie Brown (1997). Jackson usually played bad guys and drug addicts before becoming an action hero, co-starring with Bruce Willis in Die Hard: With a Vengeance (1995) and Geena Davis in The Long Kiss Goodnight (1996).",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQ1NTQwMTYxNl5BMl5BanBnXkFtZTYwMjA1MzY1._V1_.jpg",
                YearBorn = new DateTime(1948, 12, 21)
            };

            actors.Add(actor);

            return actors.ToArray();
        }
    }
}
