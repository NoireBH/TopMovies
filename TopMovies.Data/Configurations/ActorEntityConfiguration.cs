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
                DateOfBirth = new DateTime(1997, 6, 1)
            };

            actor = new Actor()
            {
                Id = 2,
                Name = "Tim Robbins",
                Description = "Born in West Covina, California, but raised in New York City, Tim Robbins is the son of former The Highwaymen singer Gil Robbins and actress Mary Robbins (née Bledsoe). Robbins studied drama at UCLA, where he graduated with honors in 1981. That same year, he formed the Actors' Gang theater group, an experimental ensemble that expressed radical political observations through the European avant-garde form of theater. He started film work in television movies in 1983, but hit the big time in 1988 with his portrayal of dimwitted fastball pitcher \"Nuke\" Laloosh in Bull Durham (1988). Tall with baby-faced looks, he has the ability to play naive and obtuse (Cadillac Man (1990) and The Hudsucker Proxy (1994)) or slick and shrewd (The Player (1992) and Bob Roberts (1992)).",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI1OTYxNzAxOF5BMl5BanBnXkFtZTYwNTE5ODI4._V1_FMjpg_UX1000_.jpg",
                DateOfBirth = new DateTime(1958, 10, 16)
            };

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 3,
                Name = "Clancy Brown",
                Description = "A tall, wavy-haired US actor with a deep, resonant voice, Clancy Brown has proven himself a versatile performer with first-class contributions to theatre, feature films, television series and even animation.\r\n\r\nClarence J. Brown III was born in 1959 in Urbana, Ohio, to Joyce Helen (Eldridge), a concert pianist, conductor, and composer, and Clarence J. \"Bud\" Brown, Jr., who helped manage the Brown Publishing Company, the family-owned newspaper started by Clancy's grandfather, Clarence J. Brown. Clancy's father and grandfather were also Republican congressmen from the same Ohio district, and Clancy spent much of his youth in close proximity to Washington, D.C. He plied his dramatic talents in the Chicago theatre scene before moving onto feature film with a sinister debut performance bullying Sean Penn inside a youth reformatory in Bad Boys (1983). He portrayed Viktor the Monster in the unusual spin on the classic Frankenstein story in The Bride (1985), before scoring one of his best roles to date as the evil Kurgan hunting fellow immortals Christopher Lambert and Sean Connery across four centuries of time in Highlander (1986).\r\n\r\nBrown played a corrupt American soldier in the Walter Hill-directed hyper-violent action film Extreme Prejudice (1987), another deranged killer in Deadly Pursuit (1988) and a brutal prison guard, who eventually somewhat \"befriends\" wrongfully convicted banker Tim Robbins, in the moving The Shawshank Redemption (1994). His superb vocal talents were in demand, and he contributed voices to animated series, including Mortal Kombat: Defenders of the Realm (1995), Street Sharks (1994), Gargoyles (1994) and Superman: The Animated Series (1996). Brown then landed two more plum roles, one as a \"tough-as-nails\" drill sergeant in the science fiction thriller Starship Troopers (1997), and the other alongside Robin Williams in the Disney comedy Flubber (1997).\r\n\r\nThe video gaming industry took notice of Clancy's vocal abilities, too, and he has contributed voices to several top selling video games, including Crash Bandicoot: The Wrath of Cortex (2001), Lands of Lore III (1999), Star Wars: Bounty Hunter (2002) and Crash Nitro Kart (2003). His voice is also the character of cranky crustacean Mr. Eugene H. Krabs in the highly successful SpongeBob SquarePants (1999) animated series and films, and he contributed voices to The Batman (2004), Jackie Chan Adventures (2000) and Justice League (2001) animated series. A popular and friendly personality, Clancy Brown continues to remain busy both through his vocal and acting talents in Hollywood.",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTUxODY3NjAzMF5BMl5BanBnXkFtZTcwMTQ5MjYwNg@@._V1_FMjpg_UX1000_.jpg",
                DateOfBirth = new DateTime(1959, 1, 5)
            };

            actors.Add(actor);

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 4,
                Name = "Al Pacino",
                Description = "Alfredo James \"Al\" 'Pacino established himself as a film actor during one of cinema's most vibrant decades, the 1970s, and has become an enduring and iconic figure in the world of American movies.He was born April 25, 1940 in Manhattan, New York City, to Italian-American parents, Rose (nee Gerardi) and Sal Pacino. They divorced when he was young. His mother moved them into his grandparents' home in the South Bronx. Pacino found himself often repeating the plots and voices of characters he had seen in the movies. Bored and unmotivated in school, he found a haven in school plays, and his interest soon blossomed into a full-time career. Starting onstage, he went through a period of depression and poverty, sometimes having to borrow bus fare to succeed to auditions. He made it into the prestigious Actors Studio in 1966, studying under Lee Strasberg, creator of the Method Approach that would become the trademark of many 1970s-era actors.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Al_Pacino_2016_%2830401544240%29.jpg/640px-Al_Pacino_2016_%2830401544240%29.jpg",
                DateOfBirth = new DateTime(1940, 4, 25)
            };
            actors.Add(actor);

            actor = new Actor()
            {
                Id = 5,
                Name = "Diane Keaton",
                Description = "Diane Keaton was born Diane Hall in Los Angeles, California, to Dorothy Deanne (Keaton), an amateur photographer, and John Newton Ignatius \"Jack\" Hall, a civil engineer and real estate broker. She studied Drama at Santa Ana College, before dropping out in favor of the Neighborhood Playhouse in New York. After appearing in summer stock for several months, she got her first major stage role in the Broadway rock musical \"Hair\". As understudy to the lead, she gained attention by not removing any of her clothing. In 1968, Woody Allen cast her in his Broadway play \"Play It Again, Sam,\" which had a successful run. It was during this time that she became involved with Allen and appeared in a number of his films. The first one was Play It Again, Sam (1972), the screen adaptation of the stage play. That same year Francis Ford Coppola cast her as Kay in the Oscar-winning The Godfather (1972), and she was on her way to stardom. She reprized that role in the film's first sequel, The Godfather Part II (1974). She then appeared with Allen again in Sleeper (1973) and Love and Death (1975).\r\n\r\nIn 1977, she broke away from her comedy image to appear in the chilling Mr. Goodbar (1977), which won her a Golden Globe nomination. It was the same year that she appeared in what many regard as her best performance, in the title role of Annie Hall (1977), which Allen wrote specifically for her (her real last name is Hall, and her nickname is Annie), and what an impact she made. She won the Oscar and the British Award for Best Actress, and Allen won the Directors Award from the DGA. She started a fashion trend with her unisex clothes and was the poster girl for a lot of young males. Her mannerisms and awkward speech became almost a national craze. The question being asked, though, was, \"Is she just a lightweight playing herself, or is there more depth to her personality?\" For whatever reason, she appeared in but one film a year for the next two years and those films were by Allen. When they broke up she was next involved with Warren Beatty and appeared in his film Reds (1981), as the bohemian female journalist Louise Bryant. For her performance, she received nominations for the Academy Award and the Golden Globe. For the rest of the 1980s she appeared infrequently in films but won nominations in three of them. Attempting to break the typecasting she had fallen into, she took on the role of a confused, somewhat naive woman who becomes involved with Middle Eastern terrorists in The Little Drummer Girl (1984). To offset her lack of movie work, Diane began directing. She directed the documentary Heaven (1987), as well as some music videos. For television she directed an episode of the popular, but strange, Twin Peaks (1990).",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTY5NDI5OTEyOF5BMl5BanBnXkFtZTgwMzU4NDI1NzM@._V1_FMjpg_UX1000_.jpg",
                DateOfBirth = new DateTime(1946, 1, 5)
            };

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 6,
                Name = "Gianni Russo",
                Description = "With a singularly nebulous background, which, by his account, included stints as a Las Vegas nightclub emcee, radio personality and jewelry tycoon, and with comparatively little acting experience, Gianni Russo won the role of Carlo Rizzi in The Godfather (1972) on the basis of his screen test. Since then, Russo has remained busy as an actor, mostly playing assorted \"wiseguys\" and Mafia types. He appeared again with Marlon Brando in a small role in The Freshman (1990) where Brando parodied his Don Corleone role to good effect.",
                ImageUrl = "Gianni Russo",
                DateOfBirth = new DateTime(1943, 9, 12)
            };

            actor = new Actor()
            {
                Id = 7,
                Name = "Christian Bale",
                Description = "Christian Charles Philip Bale was born in Pembrokeshire, Wales, UK on January 30, 1974, to English parents Jennifer \"Jenny\" (James) and David Bale. His mother was a circus performer and his father, who was born in South Africa, was a commercial pilot. The family lived in different countries throughout Bale's childhood, including England, Portugal, and the United States. Bale acknowledges the constant change was one of the influences on his career choice.\r\n\r\nHis first acting job was a cereal commercial in 1983; amazingly, the next year, he debuted on the West End stage in \"The Nerd\". A role in the 1986 NBC mini-series Anastasia: The Mystery of Anna (1986) caught Steven Spielberg's eye, leading to Bale's well-documented role in Empire of the Sun (1987). For the range of emotions he displayed as the star of the war epic, he earned a special award by the National Board of Review for Best Performance by a Juvenile Actor.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Christian_Bale_2009.jpg/800px-Christian_Bale_2009.jpg",
                DateOfBirth = new DateTime(1974, 1, 30)
            };

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 8,
                Name = "Heath Ledger",
                Description = "When hunky, twenty-year-old heart-throb Heath Ledger first came to the attention of the public in 1999, it was all too easy to tag him as a \"pretty boy\" and an actor of little depth. He spent several years trying desperately to sway this image, but this was a double-edged sword. His work comprised nineteen films, including 10 Things I Hate About You (1999), The Patriot (2000), A Knight's Tale (2001), Monster's Ball (2001), Ned Kelly (2003), The Brothers Grimm (2005), Lords of Dogtown (2005), Brokeback Mountain (2005), Casanova (2005), Candy (2006), I'm Not There (2007), The Dark Knight (2008) and The Imaginarium of Doctor Parnassus (2009). He also produced and directed music videos and aspired to be a film director.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ea/Heath_Ledger_%282%29.jpg",
                DateOfBirth = new DateTime(1979, 4, 4)
            };

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 9,
                Name = "Cillian Murphy",
                Description = "",
                ImageUrl = "",
                DateOfBirth = new DateTime(1976, 5 ,25)
            };

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 10,
                Name = "Leigh Whannell",
                Description = "Leigh Whannell grew up in Melbourne, Australia, where, at the age of four, he developed an obsession with telling stories. Whether it be through acting, writing or filmmaking, his primary love was getting a reaction from an audience. In 1995, at the age of 18, he was accepted into the Royal Melbourne Institute of Technology's prestigious Media Arts course, where he met fellow filmmaker James Wan. In his second year of college, he landed the role of \"film guy\" on a Saturday morning TV show aimed at teens called Recovery (1996). Filmed totally live in the studio and hosted by actual teenagers, the ground-breaking show was hugely popular down under and was the first to bring \"alternative culture\" to Australia's TV screens, featuring live performances from bands like Sonic Youth, Weezer, Public Enemy, Ben Harper, Pulp and hundreds more. Hosting the film component of the show, Leigh was lucky enough to interview people like Tim Burton, Peter Jackson, Russell Crowe, George Clooney, and eventually went on the host the show in 1999. After graduating from college, Leigh found himself working more and more as a \"host\" or \"presenter\" on Australian TV - all the while hatching a plan with James Wan to finally fulfill his dream of making a film. Small acting roles cropped up from time to time (including one in The Matrix Reloaded (2003), which Leigh has said was \"the most fun I've ever had in my life\") and, along with those, some frustrating near-misses (and not so near-misses: like his cringe-inducing audition for \"Lord Of The Rings\", in which he paid $90 to have \"hobbit ears\" grafted onto his head, turning up at the casting office dressed as a hobbit - needless to say he didn't get the role). However, it was missing out on a role in Alex Proyas Australian film Garage Days (2002) that finally broke the camel's back. He called Wan and told him that if they wanted to get a film made, they would have to pay for it themselves. Saw (2004) was born. After nine months of writing, Leigh had written the screenplay for what he thought would be a self-financed, \"Blair Witch\"-style feature, with him starring and James directing. The script gained so much attention that soon enough, they were shopping it around Hollywood....and the rest is history.",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTkyMzA3OTI0Ml5BMl5BanBnXkFtZTcwNDUzMTEzMQ@@._V1_FMjpg_UX1000_.jpg",
                DateOfBirth = new DateTime(1977, 1, 17)
            };

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 11,
                Name = "Cary Elwes",
                Description = "Cary Elwes was born in Westminster, London, England, the third son of interior designer/shipping heiress Tessa Georgina Kennedy and the late portrait painter Bede Evelyn Dominick Elwes. He is the brother of producer/agent Cassian Elwes and artist Damian Elwes. He was raised in London and attended Harrow. After graduating from Harrow, he moved to the US and studied drama at Sarah Lawrence College. He left school after two years to begin his film career. Cary is well respected by colleagues and fans alike and considered by many to be one of the finest actors working today. He is interested in history and says, \"It's deliberate that a lot of my films have been period pieces\". He is politically active for causes he believes in, such as protecting the environment and helping Native American people.\r\n\r\nElwes is married to Lisa Marie Kurbikoff, a stills photographer. He comes from a long-established recusant English family on his father's side. Several prominent Catholic clerics are among his relatives, including Fr. Luke Cary-Elwes, Dom Columba Cary-Elwes, and Dom Cuthbert Cary-Elwes. His grandfather was society painter and war artist Simon Elwes. Cary (the surname \"Cary-Elwes\" was shortened to \"Elwes\" in some branches of the family) was an altar boy at London's Brompton Oratory, although he did not attend a Catholic high school. From his maternal grandmother, Daska Marija Ivanovic-Banac, who was born in Osijek in the Austra-Hungarian Empire (now in Croatia), he has Croatian Jewish and Serbian ancestry. Cary's other lineage is English, Irish, and Scottish.",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BOTUxNzY3NTAxNF5BMl5BanBnXkFtZTgwNjU4MDU0NzE@._V1_FMjpg_UX1000_.jpg",
                DateOfBirth = new DateTime(1962, 10, 26)
            };

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 12,
                Name = "Tobin Bell",
                Description = "Tobin Bell is an American actor with a career in film, television and theater spanning three decades. He was born in Queens, New York and raised in Weymouth, Mass. His mother is the British actress Eileen Bell. He is perhaps best known for his role as the iconic villain \"Jigsaw\" in the Saw film series...for which he received MTV Award nominations in 2007 & 2009. He's a graduate of Boston University and has a Masters Degree in Education from Montclair State University. He studied acting with Sanford Meisner at the Neighborhood Playhouse and Lee Strasberg at the Actors Studio in New York. He is a lifetime member of The Actors Studio and a member of The Academy of Motion Picture Arts and Sciences.",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BNjM5OTE1MjA3Nl5BMl5BanBnXkFtZTgwOTAxNjk4MDE@._V1_FMjpg_UX1000_.jpg",
                DateOfBirth = new DateTime(1942, 8, 7)
            };

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 13,
                Name = "John Travolta",
                Description = "John Joseph Travolta was born in Englewood, New Jersey, one of six children of Helen Travolta (née Helen Cecilia Burke) and Salvatore/Samuel J. Travolta. His father was of Italian descent and his mother was of Irish ancestry. His father owned a tire repair shop called Travolta Tires in Hillsdale, NJ. Travolta started acting appearing in a local production of \"Who'll Save the Plowboy?\". His mother, herself an actress and dancer, enrolled him in a drama school in New York, where he studied voice, dancing and acting. He decided to combine all three of these skills and become a musical comedy performer. At 16 he landed his first professional job in a summer stock production of the musical \"Bye Bye Birdie\". He quit school at 16 and moved to New York, and worked regularly in summer stock and on television commercials. When work became scarce in New York, he went to Hollywood and appeared in minor roles in several series. A role in the national touring company of the hit 1950s musical \"Grease\" brought him back to New York. An opening in the New York production of \"Grease\" gave him his first Broadway role at age 18. After \"Grease\", he became a member of the company of the Broadway show \"Over Here\", which starred The Andrews Sisters. After ten months in \"Over Here\", he decided to try Hollywood once again. Once back in Hollywood, he had little trouble getting roles in numerous television shows. He was seen on The Rookies (1972), Emergency! (1972) and Calling Dr. Gannon (1969) and also made a movie, The Devil's Rain (1975), which was shot in New Mexico. The day he returned to Hollywood from New Mexico, he was called to an audition for a new situation comedy series ABC was planning to produce called Welcome Back, Kotter (1975). He got the part of Vinnie Barbarino and the series went on the air during the 1975 fall season.\r\n\r\nHe starred in a number of monumental films, earning his first Oscar and Golden Globe nominations for his role in the blockbuster Saturday Night Fever (1977), which launched the disco phenomenon in the 1970s. He went on to star in the big-screen version of the long-running musical Grease (1978) and the wildly successful Urban Cowboy (1980), which also influenced trends in popular culture. Additional film credits include the Brian De Palma thrillers Carrie (1976) and Blow Out (1981), as well as Amy Heckerling's hit comedy Look Who's Talking (1989) and Nora Ephron's comic hit Michael (1996). Travolta starred in Phenomenon (1996) and took an equally distinctive turn as an action star in John Woo's top-grossing Broken Arrow (1996). He also starred in the classic Face/Off (1997) opposite Nicolas Cage, and The General's Daughter (1999), co-starring Madeleine Stowe. In 2005, Travolta reprised the role of ultra cool Chili Palmer in the Get Shorty (1995) sequel Be Cool (2005). In addition, he starred opposite Scarlett Johansson in the critically-acclaimed independent feature film A Love Song for Bobby Long (2004), which was screened at the Venice Film Festival, where both Travolta and the films won rave reviews. In February 2011, John was honored by Europe's leading weekly program magazine HORZU, with the prestigious Golden Camera Award for \"Best Actor International\" in Berlin, Germany. Other recent feature film credits include box-office hit-comedy \"Wild Hogs\", the action-thriller Ladder 49 (2004), the movie version of the successful comic book The Punisher (2004), the drama Basic (2003), the psychological thriller Domestic Disturbance (2001), the hit action picture Swordfish (2001), the infamous sci-fi movie Battlefield Earth (2000), based upon the best-selling novel by L. Ron Hubbard, and Lonely Hearts (2006).\r\n\r\nTravolta has been honored twice with Academy Award nominations, the latest for his riveting portrayal of a philosophical hit-man in Quentin Tarantino's Pulp Fiction (1994). He also received BAFTA and Golden Globe nominations for this highly-acclaimed role and was named Best Actor by the Los Angeles Film Critics Association, among other distinguished awards. Travolta garnered further praise as a Mafioso-turned-movie producer in the comedy sensation Get Shorty (1995), winning the Golden Globe Award for Best Actor in a Motion Picture, Musical or Comedy. In 1998, Travolta was honored by the British Academy of Film and Television Arts with the Britanna Award: and in that same year he received the Lifetime Achievement Award at the Chicago Film Festival. Travolta also won the prestigious Alan J. Pakula Award from the US Broadcast Critics Association for his performance in A Civil Action (1998), based on the best-selling book and directed by Steven Zaillian. He was nominated again for a Golden Globe for his performance in Primary Colors (1998), directed by Mike Nichols and co-starring Emma Thompson and Billy Bob Thornton, and in 2008, he received his sixth Golden Globe nomination for his role as \"Edna Turnblad\" in the big-screen, box-office hit, Hairspray (2007). As a result of this performance, the Chicago Film Critics and the Santa Barbara Film Festival decided to recognize Travolta with a Lifetime Achievement Award for his role.\r\n\r\nIn addition, Travolta starred opposite Denzel Washington in Tony Scott's remake The Taking of Pelham 123 (2009), and he provided the voice of the lead character in Walt Disney Pictures' animated hit Bolt (2008), which was nominated for a 2009 Academy Award for Best Animated Feature Film and a Golden Globe for Best Animated Film, in addition to Best Song for John and Miley Cyrus' duet titled, \"I Thought I Lost You\".\r\n\r\nNext, Travolta starred in Walt Disney Pictures' Old Dogs (2009), along with Robin Williams, Kelly Preston and Ella Bleu Travolta, followed by the action thriller From Paris with Love (2010), starring opposite Jonathan Rhys Meyers. In 2012, John starred alongside Taylor Kitsch, Blake Lively, Aaron Taylor-Johnson, Benicio Del Toro, Salma Hayek, Emile Hirsch and Demián Bichir in Oliver Stone's, Savages (2012). The film was based on Don Winslow's best-selling crime novel that was named one of The New York Times' Top 10 Books of 2010. John was most recently seen in Killing Season (2013), co-starring Robert De Niro, and directed by Mark Steven Johnson. John recently completed production on the Boston-based film, The Forger (2014), alongside Academy Award winner Christopher Plummer and Critic's Choice nominee Tye Sheridan. John plays a second-generation petty thief who arranges to get out of prison to spend time with his ailing son (Sheridan) by taking on a job with his father (Plummer) to pay back the syndicate that arranged his release. John has received 2 prestigious aviation awards: in 2003, the American Institute of Aeronautics and Astronautics Foundation Award for Excellence for his efforts to promote commercial flying, and, in 2007, The Living Legends Ambassador of Aviation award.\r\n\r\nJohn holds 11 jet licenses: 747, 707, Gulfstream II, Lear 24, Hawker 1251A, Eclipse Jet, Vampire Jet, Canadair CL-141 Jet, Soko Jet, Citation ISP and Challenger. Travolta is the Qantas Airways Global Goodwill \"Ambassador-at-Large\" and piloted the original Qantas 707 during \"Spirit of Friendship\" global tour in July/August 2002. John is also a business aircraft brand ambassador for Learjet, Challenger and Global jets for the world's leading business aircraft manufacturer, Bombardier. John flew the 707 to New Orleans after the 2005 hurricane disaster bringing food and medical supplies, and in 2010, again flew the 707, this time to Haiti after the earthquake, carrying supplies, doctors and volunteers.\r\n\r\nJohn, along with his late wife, actress Kelly Preston (1962-2020), were very involved in their charity, The Jett Travolta Foundation, which raises money for children with educational needs.",
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMyMjZlYzgtZWRjMC00OTRmLTllZTktMmM1ODVmNjljMTQyXkEyXkFqcGdeQXVyMTExNzQ3MzAw._V1_.jpg",
                DateOfBirth = new DateTime(1954, 1, 18)
            };

            actors.Add(actor);

            actor = new Actor()
            {
                Id = 14,
                Name = "Uma Thurman",
                Description = "Uma Karuna Thurman was born in Boston, Massachusetts, into a highly unorthodox and internationally-minded family. She is the daughter of Nena Thurman (née Birgitte Caroline von Schlebrügge), a fashion model and socialite who now runs a mountain retreat, and of Robert Thurman (Robert Alexander Farrar Thurman), a professor and academic who is one of the nation's foremost Buddhist scholars. Uma's mother was born in Mexico City, Mexico, to a German father and a Swedish mother (who herself was of Swedish, Danish, and German descent). Uma's father, a New Yorker, has English, Scots-Irish, Scottish, and German ancestry. Uma grew up in Amherst, Massachusetts, where her father worked at Amherst College.\r\n\r\nShe and her siblings all have names deriving from Buddhist mythology; and Middle American behavior was little understood, much less pursued. And so it was that the young Thurman confronted childhood with an odd name and eccentric home life -- and nature seemingly conspired against her as well. She is six feet tall, and from an early age towered over everyone else in class. Her famously large feet would soon sprout to size 11 -- and even beyond that -- and although they would eventually be lovingly filmed by director Quentin Tarantino, as a child she generally wore the biggest shoes in class, which only provided another subject of ridicule. Even her long nose moved one of her mother's friends to helpfully suggest rhinoplasty -- to the ten-year-old Thurman. To make matters worse yet, the family constantly relocated, making the gangly, socially inept Thurman perpetually the new kid in class. The result was an exceptionally awkward, self-conscious, lonely and alienated childhood.\r\n\r\nUnsurprisingly, the young Thurman enjoyed making believe she was someone other than herself, and so thrived at acting in school plays -- her sole successful extracurricular activity. This interest, and her lanky frame, perfect for modeling, led the 15-year-old Thurman to New York City for high school and modeling work (including a layout in Glamour Magazine) as she sought acting roles. The roles soon came, starting with a few formulaic and forgettable Hollywood products, but immediately followed by Terry Gilliam's The Adventures of Baron Munchausen (1988) and Stephen Frears' Dangerous Liaisons (1988), both of which brought much attention to her unorthodox sensuality and performances that intriguingly combined innocence and worldliness. The weird, gangly girl became a sex symbol virtually overnight.\r\n\r\nThurman continued to be offered good roles in Hollywood pictures into the early '90s, the least commercially successful but probably best-known of which was her smoldering, astonishingly-adult performance as June, Henry Miller's wife, in Henry & June (1990), the first movie to actually receive the dreaded NC-17 rating in the USA. After a celebrated start, Thurman's career stalled in the early '90s with movies such as the mediocre Mad Dog and Glory (1993). Worse, her first starring role was in Even Cowgirls Get the Blues (1993), which had endured a tortured journey from cult-favorite book to big-budget movie, and was a critical and financial debacle. Fortunately, Uma bounced back with a brilliant performance as Mia Wallace, that most unorthodox of all gangster's molls, in Tarantino's lauded, hugely successful Pulp Fiction (1994), a role for which Thurman received an Academy Award nomination.\r\n\r\nSince then, Thurman has had periods of flirting with roles in arty independents such as A Month by the Lake (1995), and supporting roles in which she has lent some glamorous presence to a mixed batch of movies, such as Beautiful Girls (1996) and The Truth About Cats & Dogs (1996). Thurman returned to smaller films after playing the villainess Poison Ivy in the reviled Joel Schumacher effort Batman & Robin (1997) and Emma Peel in a remake of The Avengers (1998). She worked with Woody Allen and Sean Penn on Sweet and Lowdown (1999), and starred in Richard Linklater's drama Tape (2001) opposite Hawke. Thurman also won a Golden Globe award for her turn in the made-for-television film Hysterical Blindness (2002), directed by Mira Nair.\r\n\r\nA return to the mainstream spotlight came when Thurman re-teamed with Quentin Tarantino for Kill Bill: Vol. 1 (2003), a revenge flick the two had dreamed up on the set of Pulp Fiction (1994). She also turned up in the John Woo cautioner Paycheck (2003) that same year. The renewed attention was not altogether welcome because Thurman was dealing with the break-up of her marriage with Hawke at about this time. Thurman handled the situation with grace, however, and took her surging popularity in stride. She garnered critical acclaim for her work in Kill Bill: Vol. 2 (2004) and was hailed as Tarantino's muse. Thurman reunited with Pulp Fiction (1994) dance partner John Travolta for the Get Shorty (1995) sequel Be Cool (2005) and played Ulla in The Producers (2005).\r\n\r\nThurman had been briefly married to Gary Oldman, from 1990 to 1992. In 1998, she married Ethan Hawke, her co-star in the offbeat futuristic thriller Gattaca (1997). The couple had two children, Levon and Maya. Hawke and Thurman filed for divorce in 2004.",
                ImageUrl = "",
                DateOfBirth = new DateTime(1970, 4, 29)
            };

            actors.Add(actor);

            return actors.ToArray();
        }
    }
}
