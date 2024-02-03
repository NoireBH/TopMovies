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
			throw new NotImplementedException();
		}

		private Actor[] SeedActors()
		{

			var actors = new HashSet<Actor>();

			Actor actor;

			actor = new Actor()
			{
				Name = "Morgan Freeman",
				Description = "With an authoritative voice and calm demeanor, this ever popular American actor has grown into one of the most respected figures in modern US cinema. Morgan was born on June 1, 1937 in Memphis, Tennessee, to Mayme Edna (Revere), a teacher, and Morgan Porterfield Freeman, a barber. The young Freeman attended Los Angeles City College before serving several years in the US Air Force as a mechanic between 1955 and 1959. His first dramatic arts exposure was on the stage including appearing in an all-African American production of the exuberant musical Hello, Dolly!.",
				ImageUrl = "https://image.tmdb.org/t/p/w500/jPsLqiYGSofU4s6BjrxnefMfabb.jpg",
				YearBorn = new DateTime(1997, 6, 1)
			};

			actors.Add(actor);

			actor = new Actor()
			{
				Name = "Al Pacino",
				Description = "Alfredo James \"Al\" 'Pacino established himself as a film actor during one of cinema's most vibrant decades, the 1970s, and has become an enduring and iconic figure in the world of American movies.He was born April 25, 1940 in Manhattan, New York City, to Italian-American parents, Rose (nee Gerardi) and Sal Pacino. They divorced when he was young. His mother moved them into his grandparents' home in the South Bronx. Pacino found himself often repeating the plots and voices of characters he had seen in the movies. Bored and unmotivated in school, he found a haven in school plays, and his interest soon blossomed into a full-time career. Starting onstage, he went through a period of depression and poverty, sometimes having to borrow bus fare to succeed to auditions. He made it into the prestigious Actors Studio in 1966, studying under Lee Strasberg, creator of the Method Approach that would become the trademark of many 1970s-era actors.",
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3e/Al_Pacino_2016_%2830401544240%29.jpg/640px-Al_Pacino_2016_%2830401544240%29.jpg",
				YearBorn = new DateTime(1940, 4, 25)
			};
			actors.Add(actor);

			actor = new Actor()
			{
				Name = "Christian Bale",
				Description = "Christian Charles Philip Bale was born in Pembrokeshire, Wales, UK on January 30, 1974, to English parents Jennifer \"Jenny\" (James) and David Bale. His mother was a circus performer and his father, who was born in South Africa, was a commercial pilot. The family lived in different countries throughout Bale's childhood, including England, Portugal, and the United States. Bale acknowledges the constant change was one of the influences on his career choice.\r\n\r\nHis first acting job was a cereal commercial in 1983; amazingly, the next year, he debuted on the West End stage in \"The Nerd\". A role in the 1986 NBC mini-series Anastasia: The Mystery of Anna (1986) caught Steven Spielberg's eye, leading to Bale's well-documented role in Empire of the Sun (1987). For the range of emotions he displayed as the star of the war epic, he earned a special award by the National Board of Review for Best Performance by a Juvenile Actor.",
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Christian_Bale_2009.jpg/800px-Christian_Bale_2009.jpg",
				YearBorn = new DateTime(1974, 1, 30)
			};

			actors.Add(actor);

			actor = new Actor()
			{
				Name = "Heath Ledger",
				Description = "When hunky, twenty-year-old heart-throb Heath Ledger first came to the attention of the public in 1999, it was all too easy to tag him as a \"pretty boy\" and an actor of little depth. He spent several years trying desperately to sway this image, but this was a double-edged sword. His work comprised nineteen films, including 10 Things I Hate About You (1999), The Patriot (2000), A Knight's Tale (2001), Monster's Ball (2001), Ned Kelly (2003), The Brothers Grimm (2005), Lords of Dogtown (2005), Brokeback Mountain (2005), Casanova (2005), Candy (2006), I'm Not There (2007), The Dark Knight (2008) and The Imaginarium of Doctor Parnassus (2009). He also produced and directed music videos and aspired to be a film director.",
				ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ea/Heath_Ledger_%282%29.jpg",
				YearBorn = new DateTime(1979, 4, 4)
			};

			actors.Add(actor);

			actor = new Actor()
			{
				Name = "Samuel L. Jackson",
				Description = "Samuel L. Jackson is an American producer and highly prolific actor, having appeared in over 100 films, including Die Hard: With a Vengeance (1995), Unbreakable (2000), Shaft (2000), The 51st State (2001), Black Snake Moan (2006), Snakes on a Plane (2006), and the Star Wars prequel trilogy (1999-2005), as well as the Marvel Cinematic Universe.\r\n\r\nSamuel Leroy Jackson was born in Washington, D.C., to Elizabeth (Montgomery) and Roy Henry Jackson. He was raised by his mother, a factory worker, and his grandparents. At Morehouse College, Jackson was active in the black student movement. In the seventies, he joined the Negro Ensemble Company (together with Morgan Freeman). In the eighties, he became well-known after three movies made by Spike Lee: Do the Right Thing (1989), Mo' Better Blues (1990) and Jungle Fever (1991). He achieved prominence and critical acclaim in the early 1990s with films such as Patriot Games (1992), Amos & Andrew (1993), True Romance (1993), Jurassic Park (1993), and his collaborations with director Quentin Tarantino, including Pulp Fiction (1994), Jackie Brown (1997), and later Django Unchained (2012). Going from supporting player to leading man, his performance in Pulp Fiction (1994) gave him an Oscar nomination for his character Jules Winnfield, and he received a Silver Berlin Bear for his part as Ordell Robbi in Jackie Brown (1997). Jackson usually played bad guys and drug addicts before becoming an action hero, co-starring with Bruce Willis in Die Hard: With a Vengeance (1995) and Geena Davis in The Long Kiss Goodnight (1996).",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTQ1NTQwMTYxNl5BMl5BanBnXkFtZTYwMjA1MzY1._V1_.jpg",
				YearBorn = new DateTime(1948,12,21)
			};

			actors.Add(actor);

			return actors.ToArray();
		}
	}
}
