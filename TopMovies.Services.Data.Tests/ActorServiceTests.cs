using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Services.Mapping;
using TopMovies.Web.ViewModels.Actors;
using TopMovies.Web.ViewModels;
using System.Reflection;
using TopMovies.Data.Models;

namespace TopMovies.Services.Data.Tests
{
	public class ActorServiceTests
	{
		private DbContextOptions<TopMoviesDbContext> dbOptions;
		private TopMoviesDbContext context;
		private IActorService service;

		[SetUp]
		public void OneTimeSetUp()
		{
			dbOptions = new DbContextOptionsBuilder<TopMoviesDbContext>()
				.UseInMemoryDatabase("HouseRentingInMemory" + Guid.NewGuid())
				.Options;
			context = new TopMoviesDbContext(dbOptions);
			service = new ActorService(context);

			AutoMapperConfig.RegisterMappings(
			typeof(ActorDetailsViewModel).GetTypeInfo().Assembly,
			typeof(ErrorViewModel).GetTypeInfo().Assembly);

			Seed();
		}

		[TearDown]
		public void TearDownDb() => context.Dispose();

		[Test]
		public async Task AddActorAndRoleToMovieAsyncShouldIncreaseCount()
		{

			var actorRole = new MovieActorAndRoleAddOrEditFormModel()
			{
				ActorId = 1,
				ActorName = "Test",
				ActorDescription = "TestDesc",
				ActorImageUrl = "TestImg",
				ActorDateOfBirth = new DateTime(1997, 6, 1),
				MovieCharacterName = "TestMCName",
				MovieCharacterImageUrl = "TestMCImg",
				MovieCharacterAge = 5
			};

			string movieId = "2CA61990-FE17-483C-863D-442EE4C0ACAD";

			await service.AddActorAndRoleToMovieAsync(actorRole, movieId);

			Assert.That(context.ActorMovies.Count(), Is.EqualTo(2));
			Assert.That(context.MovieCharacters.Count(), Is.EqualTo(2));
		}

		[Test]
		public async Task DeleteActorAndRoleFromMovieByTheirIdsAsyncShouldReduceCount()
		{

			string movieId = "2CA61990-FE17-483C-863D-442EE4C0ACAD".ToLower();
			int actorId = 2;
			int expectedCount = 0;

			await service.DeleteActorAndRoleFromMovieByTheirIdsAsync(movieId, actorId);

			int actualActoMoviesCount = context.ActorMovies.Count();
			int actualMovieCharactersCount = context.MovieCharacters.Count();

			Assert.That(actualActoMoviesCount, Is.EqualTo(expectedCount));
			Assert.That(actualMovieCharactersCount, Is.EqualTo(expectedCount));
		}

		[Test]
		public async Task ExistsByIdAsyncReturnsTrueIfActorExists()
		{
			int actorId = 2;
			bool actual = await service.ExistsByIdAsync(actorId);

			Assert.That(actual, Is.True);
		}

		[Test]
		public async Task ExistsByIdAsyncReturnsTrueIfActorDoesntExists()
		{
			int actorId = 99;
			bool actual = await service.ExistsByIdAsync(actorId);

			Assert.That(actual, Is.False);
		}

		[Test]
		public async Task ExistsByActorAndMovieCharacterNamesReturnsTrueIfTheyExist()
		{
			string actorName = "Tim Robbins";
			string movieCharacterName = "Andy Dufresne";
			bool actual = await service.ExistsByActorAndMovieCharacterNames(actorName, movieCharacterName);

			Assert.That(actual, Is.True);
		}

		[Test]
		public async Task ExistsByActorAndMovieCharacterNamesReturnsFalseIfTheyDontExist()
		{
			string actorName = "Timmy Alen";
			string movieCharacterName = "Andy Robbins";
			bool actual = await service.ExistsByActorAndMovieCharacterNames(actorName, movieCharacterName);

			Assert.That(actual, Is.False);
		}

		[Test]
		public async Task GetActorByIdAsyncShouldReturnActor()
		{
			int actorId = 2;

			string expectedName = "Tim Robbins";
			string expectedDescription = "Born in West Covina, California, but raised in New York City, Tim Robbins is the son of former The Highwaymen singer Gil Robbins and actress Mary Robbins (née Bledsoe). Robbins studied drama at UCLA, where he graduated with honors in 1981. That same year, he formed the Actors' Gang theater group, an experimental ensemble that expressed radical political observations through the European avant-garde form of theater. He started film work in television movies in 1983, but hit the big time in 1988 with his portrayal of dimwitted fastball pitcher \"Nuke\" Laloosh in Bull Durham (1988). Tall with baby-faced looks, he has the ability to play naive and obtuse (Cadillac Man (1990) and The Hudsucker Proxy (1994)) or slick and shrewd (The Player (1992) and Bob Roberts (1992)).";
			string expectedImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI1OTYxNzAxOF5BMl5BanBnXkFtZTYwNTE5ODI4._V1_FMjpg_UX1000_.jpg";
			string expectedDateOfBirth = "1958-10-16";

			var actual = await service.GetActorByIdAsync(actorId);

			Assert.That(expectedName, Is.EqualTo(actual.Name));
			Assert.That(expectedDescription, Is.EqualTo(actual.Description));
			Assert.That(expectedImageUrl, Is.EqualTo(actual.ImageUrl));
			Assert.That(expectedDateOfBirth, Is.EqualTo(actual.DateOfBirth));
		}

		[Test]
		public async Task GetAllMovieActorsByMovieIdAsyncShouldReturnCorrectly()
		{
			string movieId = "2CA61990-FE17-483C-863D-442EE4C0ACAD".ToLower();
			int expected = 1;

			var actual = await service.GetAllMovieActorsByMovieIdAsync(movieId);

			Assert.That(expected, Is.EqualTo(actual.Length));
		}

		[Test]
		public async Task GetAllOfTheActorsMoviesByIdAsyncShouldReturnCorrectly()
		{
			int actorId = 2;
			int expectedCount = 1;
			string expectedName = "The Shawshank Redemption";
			string expectedImageUrl = "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1200_.jpg";

			var actual = await service.GetAllOfTheActorsMoviesByIdAsync(actorId);

			Assert.That(expectedCount, Is.EqualTo(actual.Length));
			Assert.That(expectedName, Is.EqualTo(actual[0].MovieName));
			Assert.That(expectedImageUrl, Is.EqualTo(actual[0].MovieImageUrl));
		}

		[Test]
		public async Task ExistsByActorAndMovieIdAsyncShouldReturnTrueIfTheyExist()
		{
			string movieId = "2CA61990-FE17-483C-863D-442EE4C0ACAD".ToLower();
			int actorId = 2;

			bool actual = await service.ExistsByActorAndMovieIdAsync(actorId, movieId);

			Assert.That(actual, Is.True);
		}

		[Test]
		public async Task ExistsByActorAndMovieIdAsyncShouldReturnFalseIfTheyDontExist()
		{
			string movieId = "2CA61990-FE17-483C-863D-442EE4C0ACADAS".ToLower();
			int actorId = 7;

			bool actual = await service.ExistsByActorAndMovieIdAsync(actorId, movieId);

			Assert.That(actual, Is.False);
		}

		[Test]
		public async Task EditActorAndRoleFromMovieByTheirIdsAsyncShouldEditTheData()
		{
			int actorId = 2;

			var model = new MovieActorAndRoleAddOrEditFormModel()
			{
				ActorId = 2,
				MovieId = "2CA61990-FE17-483C-863D-442EE4C0ACAD".ToLower(),
				ActorName = "Test",
				ActorDescription = "Test",
				ActorImageUrl = "Test",
				ActorDateOfBirth = new DateTime(1997, 6, 1),
				MovieCharacterName = "Test",
				MovieCharacterAge = 11,
				MovieCharacterImageUrl = "Test"
			};

			await service.EditActorAndRoleFromMovieByTheirIdsAsync(model, actorId);
			var actor = await service.GetActorByIdAsync(actorId);
			var movieCharacter = await context.MovieCharacters
				.Where(mc => mc.MovieId.ToString() == model.MovieId.ToLower() && mc.ActorId == actorId)
				.FirstOrDefaultAsync();

			Assert.That(actor.Name, Is.EqualTo(model.ActorName));
			Assert.That(actor.Description, Is.EqualTo(model.ActorDescription));
			Assert.That(actor.ImageUrl, Is.EqualTo(model.ActorImageUrl));
			Assert.That(actor.DateOfBirth, Is.EqualTo("1997-06-01"));
			Assert.That(movieCharacter.Name, Is.EqualTo(model.MovieCharacterName));
			Assert.That(movieCharacter.ImageUrl, Is.EqualTo(model.MovieCharacterImageUrl));
			Assert.That(movieCharacter.Age, Is.EqualTo(model.MovieCharacterAge));

		}

		[Test]
		public async Task GetActorAndTheirRoleByMovieIdAsyncShouldReturnCorrectActorAndTheirRole()
		{
			string movieId = "2CA61990-FE17-483C-863D-442EE4C0ACAD".ToLower();
			int actorId = 2;

			string expectedActorName = "Tim Robbins";
			string expectedActorDescription = "Born in West Covina, California, but raised in New York City, Tim Robbins is the son of former The Highwaymen singer Gil Robbins and actress Mary Robbins (née Bledsoe). Robbins studied drama at UCLA, where he graduated with honors in 1981. That same year, he formed the Actors' Gang theater group, an experimental ensemble that expressed radical political observations through the European avant-garde form of theater. He started film work in television movies in 1983, but hit the big time in 1988 with his portrayal of dimwitted fastball pitcher \"Nuke\" Laloosh in Bull Durham (1988). Tall with baby-faced looks, he has the ability to play naive and obtuse (Cadillac Man (1990) and The Hudsucker Proxy (1994)) or slick and shrewd (The Player (1992) and Bob Roberts (1992)).";
			string expectedActorImgUrl = "https://m.media-amazon.com/images/M/MV5BMTI1OTYxNzAxOF5BMl5BanBnXkFtZTYwNTE5ODI4._V1_FMjpg_UX1000_.jpg";
			var expectedActorDateOfBirth = new DateTime(1958, 10, 16);
			string expectedMCName = "Andy Dufresne";
			string expectedMCImageUrl = "https://m.media-amazon.com/images/M/MV5BZTZlNGQ5MjAtZmE3OC00MWFlLWE2MWItYWY2ZTIwOTZlNDYxXkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg";

			var actualActorAndRole = await service.GetActorAndTheirRoleByMovieAndActorAsync(movieId, actorId);

			Assert.That(actualActorAndRole.ActorName, Is.EqualTo(expectedActorName));
			Assert.That(actualActorAndRole.ActorDescription, Is.EqualTo(expectedActorDescription));
			Assert.That(actualActorAndRole.ActorImageUrl, Is.EqualTo(expectedActorImgUrl));
			Assert.That(actualActorAndRole.ActorDateOfBirth, Is.EqualTo(expectedActorDateOfBirth));
			Assert.That(actualActorAndRole.MovieCharacterName, Is.EqualTo(expectedMCName));
			Assert.That(actualActorAndRole.MovieCharacterImageUrl, Is.EqualTo(expectedMCImageUrl));
			Assert.That(actualActorAndRole.MovieCharacterAge, Is.EqualTo(0));
		}


		private void Seed()
		{

			Actor actor;

			actor = new Actor()
			{
				Id = 1,
				Name = "Morgan Freeman",
				Description = "With an authoritative voice and calm demeanor, this ever popular American actor has grown into one of the most respected figures in modern US cinema. Morgan was born on June 1, 1937 in Memphis, Tennessee, to Mayme Edna (Revere), a teacher, and Morgan Porterfield Freeman, a barber. The young Freeman attended Los Angeles City College before serving several years in the US Air Force as a mechanic between 1955 and 1959. His first dramatic arts exposure was on the stage including appearing in an all-African American production of the exuberant musical Hello, Dolly!.",
				ImageUrl = "https://image.tmdb.org/t/p/w500/jPsLqiYGSofU4s6BjrxnefMfabb.jpg",
				DateOfBirth = new DateTime(1997, 6, 1)
			};

			context.Actors.Add(actor);

			actor = new Actor()
			{
				Id = 2,
				Name = "Tim Robbins",
				Description = "Born in West Covina, California, but raised in New York City, Tim Robbins is the son of former The Highwaymen singer Gil Robbins and actress Mary Robbins (née Bledsoe). Robbins studied drama at UCLA, where he graduated with honors in 1981. That same year, he formed the Actors' Gang theater group, an experimental ensemble that expressed radical political observations through the European avant-garde form of theater. He started film work in television movies in 1983, but hit the big time in 1988 with his portrayal of dimwitted fastball pitcher \"Nuke\" Laloosh in Bull Durham (1988). Tall with baby-faced looks, he has the ability to play naive and obtuse (Cadillac Man (1990) and The Hudsucker Proxy (1994)) or slick and shrewd (The Player (1992) and Bob Roberts (1992)).",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTI1OTYxNzAxOF5BMl5BanBnXkFtZTYwNTE5ODI4._V1_FMjpg_UX1000_.jpg",
				DateOfBirth = new DateTime(1958, 10, 16)
			};

			context.Actors.Add(actor);

			actor = new Actor()
			{
				Id = 3,
				Name = "Clancy Brown",
				Description = "A tall, wavy-haired US actor with a deep, resonant voice, Clancy Brown has proven himself a versatile performer with first-class contributions to theatre, feature films, television series and even animation.\r\n\r\nClarence J. Brown III was born in 1959 in Urbana, Ohio, to Joyce Helen (Eldridge), a concert pianist, conductor, and composer, and Clarence J. \"Bud\" Brown, Jr., who helped manage the Brown Publishing Company, the family-owned newspaper started by Clancy's grandfather, Clarence J. Brown. Clancy's father and grandfather were also Republican congressmen from the same Ohio district, and Clancy spent much of his youth in close proximity to Washington, D.C. He plied his dramatic talents in the Chicago theatre scene before moving onto feature film with a sinister debut performance bullying Sean Penn inside a youth reformatory in Bad Boys (1983). He portrayed Viktor the Monster in the unusual spin on the classic Frankenstein story in The Bride (1985), before scoring one of his best roles to date as the evil Kurgan hunting fellow immortals Christopher Lambert and Sean Connery across four centuries of time in Highlander (1986).\r\n\r\nBrown played a corrupt American soldier in the Walter Hill-directed hyper-violent action film Extreme Prejudice (1987), another deranged killer in Deadly Pursuit (1988) and a brutal prison guard, who eventually somewhat \"befriends\" wrongfully convicted banker Tim Robbins, in the moving The Shawshank Redemption (1994). His superb vocal talents were in demand, and he contributed voices to animated series, including Mortal Kombat: Defenders of the Realm (1995), Street Sharks (1994), Gargoyles (1994) and Superman: The Animated Series (1996). Brown then landed two more plum roles, one as a \"tough-as-nails\" drill sergeant in the science fiction thriller Starship Troopers (1997), and the other alongside Robin Williams in the Disney comedy Flubber (1997).\r\n\r\nThe video gaming industry took notice of Clancy's vocal abilities, too, and he has contributed voices to several top selling video games, including Crash Bandicoot: The Wrath of Cortex (2001), Lands of Lore III (1999), Star Wars: Bounty Hunter (2002) and Crash Nitro Kart (2003). His voice is also the character of cranky crustacean Mr. Eugene H. Krabs in the highly successful SpongeBob SquarePants (1999) animated series and films, and he contributed voices to The Batman (2004), Jackie Chan Adventures (2000) and Justice League (2001) animated series. A popular and friendly personality, Clancy Brown continues to remain busy both through his vocal and acting talents in Hollywood.",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTUxODY3NjAzMF5BMl5BanBnXkFtZTcwMTQ5MjYwNg@@._V1_FMjpg_UX1000_.jpg",
				DateOfBirth = new DateTime(1959, 1, 5)
			};

			context.Actors.Add(actor);

			var movie = new Movie()
			{
				Id = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				Name = "The Shawshank Redemption",
				Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.",
				ReleaseDate = new DateTime(1994, 9, 10),
				TrailerUrl = "https://www.youtube.com/embed/NmzuHjWmXOc",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1200_.jpg",

			};


			context.Movies.Add(movie);

			var actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				ActorId = 2
			};

			context.ActorMovies.Add(actorMovie);

			var movieCharacter = new MovieCharacter()
			{
				Id = 1,
				Name = "Andy Dufresne",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BZTZlNGQ5MjAtZmE3OC00MWFlLWE2MWItYWY2ZTIwOTZlNDYxXkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg",
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				ActorId = 2
			};

			context.MovieCharacters.Add(movieCharacter);

			context.SaveChanges();
		}
	}
}
